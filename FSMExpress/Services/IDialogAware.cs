﻿using System;
using System.Threading.Tasks;

namespace FSMExpress.Services;
public interface IDialogAware
{
    public string Title { get; }
    public int Width { get; }
    public int Height { get; }

    public Task AsyncInit();
}

public interface IDialogAware<TResult> : IDialogAware
{
    public event Action<TResult?> RequestClose;
}
