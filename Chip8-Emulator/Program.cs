using System;
using System.IO;

namespace Chip8_Emulator;

class  Program
{
    static void Main()
    {
        Chip8 cpu = new Chip8();

        cpu.LoadRom("ROMS/pong.ch8");

        cpu.Run();
 
    }
}