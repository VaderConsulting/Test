# Test

Test is a C# WinForms scratch app that opens extra Form1 windows and starts a five-second BackgroundWorker on Close. New shows another `Form1`; Close queues `DoStuff` on a worker (console log, five-second sleep) then closes the form, leaving the commented `DoStuff("Normal")` path unused. The folder also keeps a copy of an empty VB.NET Rotate WinForms stub (`Form1` and `RotateClass` are empty; `Rotate` is not in `Test.sln`). That copy stays in this tree; a same-named sibling repo is at https://github.com/VaderConsulting/Rotate.

**Source last updated:** 2013-08-21 · **Language:** C# / VB.NET · **Target:** .NET Framework 4.0 (Test) / 3.5 (Rotate) · **Output:** WinForms WinExe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Test` | C# | WinForms WinExe (.NET 4.0) | Scratch Form1: New opens another window; Close starts a 5s BackgroundWorker then closes |
| `Rotate` | VB.NET | WinForms WinExe (.NET 3.5) | Empty Form1 / `RotateClass` stub; not in `Test.sln`. Sibling: [VaderConsulting/Rotate](https://github.com/VaderConsulting/Rotate) |

## How to open

Open `Test.sln` in Visual Studio 2012 (solution format 12.00). That solution builds only the C# `Test` project. Open `Rotate/Rotate.vbproj` separately in Visual Studio 2008 or later for the VB.NET stub.

## Requirements

- Visual Studio 2012, .NET Framework 3.5, .NET Framework 4.0

## Attribution and provenance

Working copy from my Historical Dev folder `Test`. `Test` assembly title/product `Test`, copyright 2013, blank company and description. `Rotate` assembly title/product `Rotate`, company Microsoft, copyright Microsoft 2010 (Visual Studio template defaults). `RotateClass.vb` is present on disk but not listed in `Rotate.vbproj`.

## License

MIT. Copyright (c) 2026 VaderConsulting, for Dave Robinson's code. See `LICENSE`.
