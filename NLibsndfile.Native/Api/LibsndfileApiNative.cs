﻿using System;
using System.Security;
using System.Runtime.InteropServices;

namespace NLibsndfile.Native
{
    [SuppressUnmanagedCodeSecurity]
    internal static class LibsndfileApiNative
    {
        [DllImport(DllImports.Libsndfile)]
        internal static extern IntPtr sf_open(string path, LibsndfileMode mode, ref LibsndfileInfo info);

        [DllImport(DllImports.Libsndfile)]
        internal static extern IntPtr sf_open_fd(int handle, LibsndfileMode mode, ref LibsndfileInfo info, int closeHandle);

        [DllImport(DllImports.Libsndfile)]
        internal static extern int sf_format_check(ref LibsndfileInfo info);

        [DllImport(DllImports.Libsndfile)]
        internal static extern long sf_seek(IntPtr sndfile, long count, int whence);

        [DllImport(DllImports.Libsndfile)]
        internal static extern LibsndfileError sf_close(IntPtr sndfile);

        [DllImport(DllImports.Libsndfile)]
        internal static extern void sf_write_sync(IntPtr sndfile);

        [DllImport(DllImports.Libsndfile)]
        internal static extern LibsndfileError sf_set_string(IntPtr sndfile, LibsndfileStringType type, string value);

        [DllImport(DllImports.Libsndfile)]
        internal static extern IntPtr sf_get_string(IntPtr sndfile, LibsndfileStringType type);

        [DllImport(DllImports.Libsndfile)]
        internal static extern long sf_read_short(IntPtr sndfile, short[] buffer, long items);

        [DllImport(DllImports.Libsndfile)]
        internal static extern long sf_read_int(IntPtr sndfile, int[] buffer, long items);
    }
}