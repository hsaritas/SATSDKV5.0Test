//---------------------------------------------------------------------------------------------
// Copyright (c) 2022, Siemens Industry, Inc.
// All rights reserved.
//
// Filename:      Program.cs
//
// Purpose:       This is the base class for the program and controls the start up screen of the program.
//
//---------------------------------------------------------------------------------------------

namespace SATExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  Kick off state machine behavior
            StateMachine machine = new StateMachine();
            machine.Start(args);
        }
    }
}