# Fly NMEA

Simple GNSS / GPS NMEA simulator for Windows written in C#.

Originally created for testing aircraft navigation software without real flights or physical GNSS hardware.  
The app generates virtual movement data and outputs NMEA sentences to a virtual COM port.

## Features

- Simulates movement using:
  - speed
  - roll
  - pitch
- Generates NMEA data streams
- Outputs to virtual serial port (COM)
- Can receive Android sensor data over UDP for tilt control

## Supported NMEA Sentences

- GLL — Geographic Position
- GSV — Satellites in View
- RMC — Recommended Minimum GNSS Data
- GSA — DOP and Active Satellites

## How It Works

1. Set initial WGS-84 coordinates  
2. Convert to flat projection  
3. Simulate movement physics  
4. Convert back to geographic coordinates  
5. Generate NMEA messages  
6. Send to virtual COM port

## Screenshot

![Fly NMEA](https://habrastorage.org/r/w1560/storage1/671d3e36/21f2781a/aaf8fd6e/b189fb18.png)

## Original Article

Detailed story and implementation notes:

https://habr.com/ru/articles/129316/

## Typical Usage

Use together with virtual COM port software:

COM1 <-> COM6

- Fly NMEA sends data to COM6
- Your navigation software reads COM1

## Notes

This is an old personal utility project preserved here for reference.
