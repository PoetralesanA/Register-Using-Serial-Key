Imports System.Security.Cryptography
Module mycrypt
    Public mykey = "poetratamvan" ' <~ merubah ini membuat program error
    Public Function AESE(ByVal plaintext As String, ByVal key As String) As String
        Dim AES As New RijndaelManaged
        Dim SHA256 As New SHA256Cng
        Dim ciphertext As String = ""
        Try
            AES.GenerateIV()
            AES.Key = SHA256.ComputeHash(System.Text.Encoding.ASCII.GetBytes(key))

            AES.Mode = CipherMode.CBC
            Dim DESEncrypter As ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.Encoding.ASCII.GetBytes(plaintext)
            ciphertext = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))

            Return Convert.ToBase64String(AES.IV) & Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function AESD(ByVal ciphertext As String, ByVal key As String) As String
        Dim AES As New RijndaelManaged
        Dim SHA256 As New SHA256Cng
        Dim plaintext As String = ""
        Dim iv As String = ""
        Try
            Dim ivct = ciphertext.Split({"=="}, StringSplitOptions.None)
            iv = ivct(0) & "=="
            ciphertext = If(ivct.Length = 3, ivct(1) & "==", ivct(1))

            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.IV = Convert.FromBase64String(iv)
            AES.Mode = CipherMode.CBC
            Dim DESDecrypter As ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(ciphertext)
            plaintext = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return plaintext
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Module
