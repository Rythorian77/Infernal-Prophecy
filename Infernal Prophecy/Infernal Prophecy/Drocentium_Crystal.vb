Imports System.Runtime.InteropServices

Public Class Drocentium_Crystal
    'This will cut memory usage in half. It went from 6.9 megabytes to  3.9 megabytes
    <DllImport("KERNEL32.DLL", EntryPoint:="SetProcessWorkingSetSize", SetLastError:=True, CallingConvention:=CallingConvention.StdCall)>
    Friend Shared Function SetProcessWorkingSetSize(pProcess As IntPtr, dwMinimumWorkingSetSize As Integer, dwMaximumWorkingSetSize As Integer) As Boolean
    End Function

    'Captures this applications process and sets its usage
    <DllImport("KERNEL32.DLL", EntryPoint:="GetCurrentProcess", SetLastError:=True, CallingConvention:=CallingConvention.StdCall)>
    Friend Shared Function GetCurrentProcess() As IntPtr
    End Function

    Public Sub New()
        Dim pHandle As IntPtr = GetCurrentProcess()
        SetProcessWorkingSetSize(pHandle, -1, -1)
    End Sub
End Class
