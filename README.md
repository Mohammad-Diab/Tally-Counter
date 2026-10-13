# Tally Counter

A small Windows tally counter: click to count up, and the count is kept between runs. Written in VB.NET with Windows Forms on .NET Framework 2.0.

## Features

- **Count** adds one. The display goes up to 99999, then wraps back to 0.
- **Rest** sets the count back to 0. While the button is held down the display shows `88888`.
- **Color** changes the window's background color.
- The count is saved to `%LocalAppData%\Tally Counter\Tally_Counter.txt` and loaded again on the next start.
- The app saves and closes itself 10 seconds after the last click (it also saves when you close the window).

## Requirements

Windows with .NET Framework 3.5 (it includes 2.0). On Windows 10 and 11 it is an optional feature: if it isn't installed, Windows offers to add it the first time the app starts, or turn it on in "Turn Windows features on or off".

## Usage

Download `Tally.Counter.7z` from [Releases](https://github.com/Mohammad-Diab/Tally-Counter/releases), extract it, and run `Tally Counter.exe`. There is no installer.

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

## Building

```
git clone https://github.com/Mohammad-Diab/Tally-Counter.git
```

Open `Tally Counter.sln` in Visual Studio and build, or run:

```
MSBuild "Tally Counter.sln" /p:Configuration=Release
```

The exe is written to `Tally Counter\bin\Release`.

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)
