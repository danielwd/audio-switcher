﻿// -----------------------------------------------------------------------
// Copyright (c) David Kean.
// -----------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace AudioSwitcher.Presentation.CommandModel
{
    // Represents a command that takes no argument
    internal abstract class Command : CommandBase
    {
        protected Command()
        {
        }

        public override sealed void Run(object argument)
        {
            if (argument != null)
                throw new ArgumentException();

            Run();
        }

        public override sealed void UpdateStatus(object argument)
        {
            if (argument != null)
                throw new ArgumentException();

            UpdateStatus();
        }

        public abstract void Run();

        public virtual void UpdateStatus()
        {
        }
    }
}
