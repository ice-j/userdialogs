﻿using System;
using System.Windows.Input;


namespace Acr.UserDialogs
{
    public static class Extensions
    {
        public static bool TryExecute(this ICommand cmd, object parameter)
        {
            if (cmd == null)
                return false;

            var execute = cmd.CanExecute(parameter);
            if (execute)
                cmd.Execute(parameter);

            return execute;
        }


        public static bool IsAnyEmpty(params TextEntry[] tbs)
        {
            foreach (var tb in tbs)
            {
                if (String.IsNullOrWhiteSpace(tb.Text))
                    return true;
            }
            return false;
        }
    }
}
