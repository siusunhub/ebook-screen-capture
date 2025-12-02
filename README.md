# eBook Screen Capture

A small Windows Forms utility for **automatically capturing a fixed area of the screen** (e.g. an e-book reader window) while **auto-clicking “next page”** and saving each page as a numbered PNG image.   

This tool is useful when you want to turn a paged viewer (PDF reader, e-book app, web viewer, etc.) into a sequence of image files without manually pressing *Print Screen* and clicking *Next* hundreds of times.

---

## Overview

The application shows a compact always-on-top toolbar window titled **“eBook Screen Capture”** with controls to: :contentReference[oaicite:1]{index=1}  

- Choose an output folder and filename prefix  
- Configure the page range and wait time between captures  
- Define the **capture rectangle** (the area of the screen to screenshot)  
- Define the **click position** (the “Next page” button/location)  
- Start/stop the automated capture process  

Internally it uses a timer to repeatedly: :contentReference[oaicite:2]{index=2}  

1. Capture the configured screen region into a `Bitmap`  
2. Save it as `<prefix>[x1,y1xX2,Y2]NNNN.png`  
3. Simulate a left mouse click at the configured click position  
4. Wait the specified number of seconds for the next page to load  

This repeats until the configured total number of pages has been captured.

---

## Main Features

### 1. Automatic paged screen capture

- Captures a rectangular region of the screen using `Graphics.CopyFromScreen`.  
- Each capture is saved as a PNG image in the selected folder. :contentReference[oaicite:3]{index=3}  
- Filenames include:
  - The user-defined prefix
  - The capture rectangle coordinates in square brackets
  - A zero-padded page number (e.g. `MyBook[100,100x800,1200]0001.png`). :contentReference[oaicite:4]{index=4}  

### 2. Automatic “Next page” clicking

- A **click position** (X, Y) is recorded once.   
- After saving each screenshot, the app:
  - Temporarily moves the mouse cursor to that position  
  - Performs a left-click using `mouse_event`  
  - Restores the cursor to its previous position  
- This allows the tool to advance pages in an e-book/PDF reader without user interaction. :contentReference[oaicite:6]{index=6}  

### 3. Visual full-screen selection of capture & click positions

The **`GetPositionFullScreen`** form is a full-screen semi-transparent overlay used to select positions:   

- **Capture area selection mode**:
  - First left-click sets the **top-left corner** of the capture rectangle.  
  - Moving the mouse shows crosshair lines and then a live rectangle outline.  
  - Second left-click sets the **bottom-right corner** and sends the rectangle back to the main form.  
  - A vertical line down the center of the rectangle is also drawn as a visual guide.  
- **Click position selection mode**:
  - A single left-click records the click coordinates used to trigger “Next page”.  
- Right-click behavior:
  - Can cancel the current step or close the overlay depending on the mode/step. :contentReference[oaicite:8]{index=8}  

### 4. Numeric fine-tuning & live preview (Custom Capture Size window)

The **`CustomCapturePosWin`** form allows numeric adjustment of the capture rectangle:   

- Shows:
  - Original coordinates of the capture area  
  - Current “saved” size in `Width x Height`  
- Provides four `NumericUpDown` controls for `X1, Y1, X2, Y2`, clamped to the current screen bounds.  
- On load and on any value change, it instructs the full-screen preview to update the rectangle, so you see the effect immediately.  
- Pressing **OK**:
  - Validates that `X2 > X1` and `Y2 > Y1`  
  - Writes the updated coordinates back to the main form  

This is especially helpful when you need pixel-perfect alignment without manually re-selecting on the overlay.

### 5. Manual one-shot capture

- A dedicated toolbar icon triggers a **single** capture of the configured region.   
- The resulting image is shown through a standard `SaveFileDialog`, allowing you to pick a custom filename and location.  

### 6. Progress & control of batch capture

The toolbar exposes: :contentReference[oaicite:11]{index=11}  

- **Start page** (`numericStartPage`)  
- **Total pages** (`numericTotalPage`)  
- **Wait seconds** between captures (`numericWaitSecond`, 3–20 seconds)  

The “Start” button validates all settings (folder, filename, page range, positions, wait time). If valid: :contentReference[oaicite:12]{index=12}  

- Locks the main window position so it cannot be moved during capture (to avoid shifting coordinates).   
- Disables editable controls while processing.  
- Enables the **Stop** button and updates a status label showing current progress `(current/total)`.  

The **Stop** button safely stops the timer, re-enables all inputs, and updates the status label to indicate the process was stopped by the user. :contentReference[oaicite:14]{index=14}  

When the last page is captured:  

- The app stops automatically, re-enables controls, and sets the status to “Finish..”. :contentReference[oaicite:15]{index=15}  

### 7. Always-on-top compact toolbar UI

- The main window is very narrow (toolbar-like) and **TopMost**, so it stays above other windows without blocking much content. :contentReference[oaicite:16]{index=16}  
- It’s positioned centered at the top of the primary screen when launched.   

### 8. “Cut Left/Right” placeholder option

- There is a checkbox **“Cut Left/Right”** in the main form. :contentReference[oaicite:20]{index=20}  
- The code currently routes both branches (on/off) through essentially the same capture logic with a comment `// not done`, so **splitting left/right pages is not yet implemented**. :contentReference[oaicite:21]{index=21}  

---

## How to Use

> Below is the intended user flow inferred from the code.

1. **Select output folder**
   - Click the folder icon next to “Save Folder”.
   - Choose the directory where all PNGs will be saved.   

2. **Enter filename prefix**
   - Type something like `MyBook_` into the “Filename Prefix” textbox. :contentReference[oaicite:23]{index=23}  

3. **Configure page range & timing**
   - Set **Start** page (e.g. `1`).  
   - Set **Total** pages to capture (e.g. `100`).  
   - Set **Wait Sec** to the amount of time needed for your viewer to load the next page (3–20 seconds).   

4. **Set capture rectangle**
   - Click the capture-position icon or the capture-position label.  
   - A full-screen translucent overlay appears:
     - First left-click = top-left of the rectangle.  
     - Move the mouse, then second left-click = bottom-right.  
   - The chosen coordinates are shown on the toolbar; you can later fine-tune them using the **Custom Capture Size** dialog (clicking the capture-pos label opens preview + numeric editor).   

5. **Set click position**
   - Click the click-position icon.  
   - On the overlay, left-click on the “Next page” button or elsewhere you want to simulate a click after each capture.   

6. **(Optional) Test a single capture**
   - Use the camera-like icon to capture once and save manually via a Save File dialog.   

7. **Start automation**
   - Confirm your e-book/PDF reader is on the first page you want.  
   - Click **Start** on the toolbar.  
   - The app will:
     - Capture the area
     - Save a PNG
     - Click “Next page”
     - Wait the configured seconds  
     - Repeat until all pages are captured  

8. **Stop if needed**
   - Press **Stop** at any time to abort the process; all UI controls will be re-enabled.   

---

## Architecture Overview

- **`Program.cs`** – Standard WinForms entry point, runs `Form1`. :contentReference[oaicite:29]{index=29}  
- **`Form1`** – Main toolbar UI and core automation logic:
  - Manages user inputs, timers, file naming, screen captures, mouse clicks, and status.   
- **`GetPositionFullScreen`** – Full-screen overlay for interactive selection and preview of capture regions and click positions.   
- **`CustomCapturePosWin`** – Small dialog to numerically tweak capture coordinates while previewing the rectangle.   
- **`DebugWin`** – Simple topmost form with a text box and “Update” button for diagnostics. :contentReference[oaicite:33]{index=33}  

All UI is implemented with standard Windows Forms controls and timers.

---

## Building from Source

From the code structure, this is a classic **Windows Forms (.NET)** application:

1. Open the project (or create one and add these files under a namespace `eBookScreenCapture`) in **Visual Studio** on Windows.  
2. Ensure the project type is **Windows Forms App** (using .NET Framework or .NET Windows Desktop).  
3. Add the provided `.cs` and `.resx` files to the project.  
4. Build and run. The application starts at `Form1`.   

---

## Known Limitations / TODO (from the code)

- “Cut Left/Right” checkbox is wired but **actual splitting logic is not implemented yet** (`// not done` comment). :contentReference[oaicite:35]{index=35}  
- No built-in error handling for situations like:
  - Changing screen resolution/layout between configuration
