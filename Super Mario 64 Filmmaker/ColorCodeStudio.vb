﻿Imports System.Drawing.Imaging
Imports System.Globalization
Imports Filmmaker.My.Resources
Imports Filmmaker.ShadowFunctions

Public Class ColorCodeStudio
    Private hatColorMap As New ColorMap()
    Private hairColorMap As New ColorMap()
    Private skinColorMap As New ColorMap()
    Private pantsColorMap As New ColorMap()
    Private glovesColorMap As New ColorMap()
    Private shoesColorMap As New ColorMap()

    Public returnedCode As String = ""
    Private rand As Random = New Random()
    Private cycleTime As Integer
    Private cycleColors As Boolean = False
    Private cycleShadows As Boolean = False
    Private CCCopyPaste As ColorCodeCopyPasteForm
    Private DefaultColors(23) As Color
    Private IsSettingAllColors As Boolean = False
    Private ShadowMode As Byte = 0

    Private Sub ColorCodeStudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Resources.CCSHat
        Label2.Text = My.Resources.CCSHair
        Label3.Text = My.Resources.CCSSkin
        Label4.Text = My.Resources.CCSOveralls
        Label5.Text = My.Resources.CCSGloves
        Label6.Text = My.Resources.CCSShoes
        Me.Text = My.Resources.CCSFormTitle
        DefaultButton.Text = CCSDefaults
        ImportCCButton.Text = CCSImport
        ExportCCButton.Text = CCSExport
        LoadRamButton.Text = CCSLoad
        Label7.Text = CCWarning
        SX_lb.Text = My.Resources.CCS_ShadeX
        SY_lb.Text = My.Resources.CCS_ShadeY
        SZ_lb.Text = My.Resources.CCS_ShadeZ
        ChangeModeBtn.Text = My.Resources.CCS_ShadingMode
        RestoreShadingBtn.Text = My.Resources.CCS_RestoreSh
        'Save the default colors as what they are when the form loads
        AssignDefaults()
        RestoreShadingBtn.PerformClick()
        hatColorMap.OldColor = Color.FromArgb(255, 0, 0)
        hairColorMap.OldColor = Color.FromArgb(115, 6, 0)
        shoesColorMap.OldColor = Color.FromArgb(114, 28, 14)
        pantsColorMap.OldColor = Color.FromArgb(0, 0, 255)
        skinColorMap.OldColor = Color.FromArgb(254, 193, 121)
        glovesColorMap.OldColor = Color.FromArgb(220, 220, 220)
        UpdateHatnShirt(Color.FromArgb(255, 0, 0))
        UpdateHair(Color.FromArgb(115, 6, 0))
        UpdateShoes(Color.FromArgb(114, 28, 14))
        UpdateOveralls(Color.FromArgb(0, 0, 255))
        UpdateSkin(Color.FromArgb(254, 193, 121))
        UpdateGloves(Color.FromArgb(220, 220, 220))
        Right_lb.Text = My.Resources.Right
        Left_lb.Text = My.Resources.Left
        High_lb.Text = My.Resources.Higher
        Low_lb.Text = My.Resources.Lower
        Back_lb.Text = My.Resources.Back
        Front_lb.Text = My.Resources.Front
        RMZ_X.Text = My.Resources.RandomX
        RMZ_Y.Text = My.Resources.RandomY
        RMZ_Z.Text = My.Resources.RandomZ
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles HatButton3.Click, HatButton1.Click, SkinButton3.Click, SkinButton1.Click,
        ShoesButton3.Click, ShoesButton1.Click, PantsButton3.Click, PantsButton1.Click, HairButton3.Click, HairButton1.Click, GlovesButton3.Click, GlovesButton1.Click

        Dim senderButton = DirectCast(sender, Button)

        'If the current button is disabled, it means we aren't hooked into SM64's memory, so we don't want to do anything or we will probably crash
        If senderButton.Enabled = False Then Exit Sub

        ColorDialog1.Color = senderButton.BackColor
        'Dim avgHatColor As Color = Color.FromArgb((HatButton1.BackColor.R + HatButton3.BackColor.R) \ 2, (HatButton1.BackColor.G + HatButton3.BackColor.G) \ 2, (HatButton1.BackColor.B + HatButton3.BackColor.B) \ 2)

        If IsSettingAllColors = True OrElse ColorDialog1.ShowDialog() = DialogResult.OK Then

            If Not IsSettingAllColors Then senderButton.BackColor = ColorDialog1.Color

            UpdateHatnShirt(HatButton3.BackColor)
            UpdateHair(HairButton3.BackColor)
            UpdateOveralls(PantsButton3.BackColor)
            UpdateGloves(GlovesButton3.BackColor)
            UpdateShoes(ShoesButton3.BackColor)
            UpdateSkin(SkinButton3.BackColor)
            MarioSprite.Refresh()

            Dim colorData As String
            colorData = FixZeroHexByte(Hex(senderButton.BackColor.R)) & FixZeroHexByte(Hex(senderButton.BackColor.G)) & FixZeroHexByte(Hex(senderButton.BackColor.B)) & "00"
            Dim bytes As String = colorData.Substring(6, 2) & colorData.Substring(4, 2) & colorData.Substring(2, 2) & colorData.Substring(0, 2)

            Dim addressToWrite As Integer = 0
            Select Case senderButton.Name
                Case "HatButton1"
                    addressToWrite = &H7EC38
                Case "HatButton2"
                    addressToWrite = &H7EC3C
                Case "HatButton3"
                    addressToWrite = &H7EC40
                Case "HatButton4"
                    addressToWrite = &H7EC44
                Case "HairButton1"
                    addressToWrite = &H7EC98
                Case "HairButton2"
                    addressToWrite = &H7EC9C
                Case "HairButton3"
                    addressToWrite = &H7ECA0
                Case "HairButton4"
                    addressToWrite = &H7ECA4
                Case "SkinButton1"
                    addressToWrite = &H7EC80
                Case "SkinButton2"
                    addressToWrite = &H7EC84
                Case "SkinButton3"
                    addressToWrite = &H7EC88
                Case "SkinButton4"
                    addressToWrite = &H7EC8C
                Case "PantsButton1"
                    addressToWrite = &H7EC20
                Case "PantsButton2"
                    addressToWrite = &H7EC24
                Case "PantsButton3"
                    addressToWrite = &H7EC28
                Case "PantsButton4"
                    addressToWrite = &H7EC2C
                Case "GlovesButton1"
                    addressToWrite = &H7EC50
                Case "GlovesButton2"
                    addressToWrite = &H7EC54
                Case "GlovesButton3"
                    addressToWrite = &H7EC58
                Case "GlovesButton4"
                    addressToWrite = &H7EC5C
                Case "ShoesButton1"
                    addressToWrite = &H7EC68
                Case "ShoesButton2"
                    addressToWrite = &H7EC6C
                Case "ShoesButton3"
                    addressToWrite = &H7EC70
                Case "ShoesButton4"
                    addressToWrite = &H7EC74
            End Select
            If addressToWrite > 0 Then
                WriteXBytes("Project64", MainForm.Base + addressToWrite, bytes)
            End If
        End If
    End Sub

    Private Sub ShadingSliderX_Scroll(sender As Object, e As EventArgs) Handles ShadingSliderX.ValueChanged
        ChangeShadowX(Hex(CSByte(ShadingSliderX.Value)))
        SpecificX_UpDown.Value = ShadingSliderX.Value
    End Sub

    Private Sub ShadingSliderY_Scroll(sender As Object, e As EventArgs) Handles ShadingSliderY.ValueChanged
        ChangeShadowY(Hex(CSByte(ShadingSliderY.Value)))
        SpecificY_UpDown.Value = ShadingSliderY.Value
    End Sub

    Private Sub ShadingSliderZ_Scroll(sender As Object, e As EventArgs) Handles ShadingSliderZ.ValueChanged
        Try
            ChangeShadowZ(Hex(CSByte((-(ShadingSliderZ.Value)))))
        Catch ex As Exception
            ShadingSliderZ.Value = -128
        End Try
        SpecificZ_UpDown.Value = ShadingSliderZ.Value
    End Sub

    Private Sub RestoreShadingBtn_Click(sender As Object, e As EventArgs) Handles RestoreShadingBtn.Click
        RestoreAllShadeValues(True)
        ShadingSliderX.Value = 40
        ShadingSliderY.Value = 40
        ShadingSliderZ.Value = -40
        SpecificX_UpDown.Value = 40
        SpecificY_UpDown.Value = 40
        SpecificZ_UpDown.Value = -40
    End Sub

    Private Sub AssignDefaults()
        Dim buttonIndex As Integer
        For Each control As Control In Controls
            If TypeOf control Is Button Then
                Dim foundButton = DirectCast(control, Button)
                'If the button has no text, it's a color-selection button
                If foundButton.Text = "" Then
                    DefaultColors(buttonIndex) = foundButton.BackColor
                    buttonIndex += 1
                End If
            End If
        Next
    End Sub

    Private Sub RestoreDefaults(sender As Object, e As EventArgs) Handles DefaultButton.Click
        'Set the default colors to what they were saved as when the form first loaded
        Dim buttonIndex As Integer
        IsSettingAllColors = True
        For Each control As Control In Controls
            If TypeOf control Is Button Then
                Dim foundButton = DirectCast(control, Button)
                'If the button has no text, it's a color-selection button
                If foundButton.Text = "" Then
                    foundButton.BackColor = DefaultColors(buttonIndex)
                    foundButton.PerformClick()
                    UpdateHatnShirt(Color.FromArgb(255, 0, 0))
                    UpdateHair(Color.FromArgb(115, 6, 0))
                    UpdateShoes(Color.FromArgb(114, 28, 14))
                    UpdateOveralls(Color.FromArgb(0, 0, 255))
                    UpdateSkin(Color.FromArgb(254, 193, 121))
                    UpdateGloves(Color.FromArgb(220, 220, 220))
                    buttonIndex += 1
                End If
            End If
        Next
        IsSettingAllColors = False
    End Sub

    Public Sub RefreshCycles()
        If ShadowMode = 0 Then
            If cycleColors = True Then
                'Uncomment the following If statement and adjust the cap (default = 1) to slow down the refresh rate
                If cycleTime >= 1 Then
                    Dim buttonIndex As Integer
                    IsSettingAllColors = True
                    For Each control As Control In Controls
                        If TypeOf control Is Button Then
                            Dim foundButton = DirectCast(control, Button)
                            'If the button has no text, it's a color-selection button
                            If foundButton.Text = "" Then
                                foundButton.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
                                foundButton.PerformClick()
                                buttonIndex += 1
                            End If
                        End If
                    Next
                    IsSettingAllColors = False
                    cycleTime = 0
                Else
                    cycleTime += 1
                End If
            End If
        Else
            If cycleShadows = True Then
                SpecificX_UpDown.Value = rand.Next(RandomizerX1.Value, RandomizerX2.Value)
                SpecificY_UpDown.Value = rand.Next(RandomizerY1.Value, RandomizerY2.Value)
                SpecificZ_UpDown.Value = rand.Next(RandomizerZ1.Value, RandomizerZ2.Value)
            End If
        End If
    End Sub

    Private Sub MarioSprite_Paint(sender As Object, e As PaintEventArgs) Handles MarioSprite.Paint
        Dim g As Graphics = e.Graphics
        Dim bmp = New Bitmap(M64MM2_CC_Mario_big)

        ' Set the image attribute's color mappings
        Dim colorMap(5) As ColorMap
        colorMap(0) = hatColorMap
        colorMap(1) = skinColorMap
        colorMap(2) = hairColorMap
        colorMap(3) = glovesColorMap
        colorMap(4) = pantsColorMap
        colorMap(5) = shoesColorMap

        Dim attr = New ImageAttributes()
        attr.SetRemapTable(colorMap)

        ' Draw using the color map
        Dim rect = New Rectangle(0, 0, e.ClipRectangle.Width, e.ClipRectangle.Height)
        g.Clear(BackColor)
        g.DrawImage(bmp, rect, 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attr)
    End Sub

    Private Sub LoadFromRam(sender As Object, e As EventArgs) Handles LoadRamButton.Click
        Dim addresses As Integer() = {&H7EC38, &H7EC3C, &H7EC40, &H7EC44, &H7EC98, &H7EC9C, &H7ECA0, &H7ECA4, &H7EC80, &H7EC84, &H7EC88, &H7EC8C, &H7EC20, &H7EC24, &H7EC28, &H7EC2C, &H7EC50, &H7EC54, &H7EC58, &H7EC5C, &H7EC68, &H7EC6C, &H7EC70, &H7EC74}

        Dim val As Byte() = BigEndianRead("Project64", MainForm.Base + addresses(0), 4)
        HatButton1.BackColor = Color.FromArgb(val(0), val(1), val(2))

        val = BigEndianRead("Project64", MainForm.Base + addresses(2), 4)
        HatButton3.BackColor = Color.FromArgb(val(0), val(1), val(2))
        UpdateHatnShirt(Color.FromArgb(val(0), val(1), val(2)))

        val = BigEndianRead("Project64", MainForm.Base + addresses(4), 4)
        HairButton1.BackColor = Color.FromArgb(val(0), val(1), val(2))

        val = BigEndianRead("Project64", MainForm.Base + addresses(6), 4)
        HairButton3.BackColor = Color.FromArgb(val(0), val(1), val(2))
        UpdateHair(Color.FromArgb(val(0), val(1), val(2)))

        val = BigEndianRead("Project64", MainForm.Base + addresses(8), 4)
        SkinButton1.BackColor = Color.FromArgb(val(0), val(1), val(2))

        val = BigEndianRead("Project64", MainForm.Base + addresses(10), 4)
        SkinButton3.BackColor = Color.FromArgb(val(0), val(1), val(2))
        UpdateSkin(Color.FromArgb(val(0), val(1), val(2)))

        val = BigEndianRead("Project64", MainForm.Base + addresses(12), 4)
        PantsButton1.BackColor = Color.FromArgb(val(0), val(1), val(2))

        val = BigEndianRead("Project64", MainForm.Base + addresses(14), 4)
        PantsButton3.BackColor = Color.FromArgb(val(0), val(1), val(2))
        UpdateOveralls(Color.FromArgb(val(0), val(1), val(2)))

        val = BigEndianRead("Project64", MainForm.Base + addresses(16), 4)
        GlovesButton1.BackColor = Color.FromArgb(val(0), val(1), val(2))

        val = BigEndianRead("Project64", MainForm.Base + addresses(18), 4)
        GlovesButton3.BackColor = Color.FromArgb(val(0), val(1), val(2))
        UpdateGloves(Color.FromArgb(val(0), val(1), val(2)))

        val = BigEndianRead("Project64", MainForm.Base + addresses(20), 4)
        ShoesButton1.BackColor = Color.FromArgb(val(0), val(1), val(2))

        val = BigEndianRead("Project64", MainForm.Base + addresses(22), 4)
        ShoesButton3.BackColor = Color.FromArgb(val(0), val(1), val(2))
        UpdateShoes(Color.FromArgb(val(0), val(1), val(2)))

        MarioSprite.Refresh()

        If MessageBox.Show(CCSDefaultMB, CCSDMBTitle, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            AssignDefaults()
        End If
    End Sub

    Private Sub ImportColorCode(sender As Object, e As EventArgs) Handles ImportCCButton.Click
        If CCCopyPaste IsNot Nothing AndAlso CCCopyPaste.IsDisposed = False Then
            CCCopyPaste.Close()
        End If

        CCCopyPaste = New ColorCodeCopyPasteForm(False, Me)
        If CCCopyPaste.ShowDialog = DialogResult.OK Then
            Try
                returnedCode = returnedCode.Replace(vbCrLf, "")
                returnedCode = returnedCode.Replace("\n", "")
                Dim len = 13
                Dim splitByLength = Enumerable.Range(0, returnedCode.Length / len).Select(Function(x) returnedCode.Substring(x * len, len)).ToArray()
                Dim colorData = New Dictionary(Of String, String)
                'Remove the first two characters from the beginning of each line of the code, because it's only used by a GameShark
                'Then, separate the address and value sections of the code
                For line As Integer = 0 To (splitByLength.Length - 1)
                    colorData.Add(splitByLength(line).Split(" ")(0).Substring(2), splitByLength(line).Split(" ")(1))
                Next

                IsSettingAllColors = True
                For code As Integer = 0 To colorData.Count - 2 Step 2
                    Dim R As Byte = Byte.Parse(colorData.Values(code).Substring(0, 2), NumberStyles.HexNumber)
                    Dim G As Byte = Byte.Parse(colorData.Values(code).Substring(2, 2), NumberStyles.HexNumber)
                    Dim B As Byte = Byte.Parse(colorData.Values(code + 1).Substring(0, 2), NumberStyles.HexNumber)
                    Select Case colorData.Keys(code).ToUpper()
                        Case "07EC38"
                            HatButton1.BackColor = Color.FromArgb(R, G, B)
                            HatButton1.PerformClick()
                        Case "07EC40"
                            HatButton3.BackColor = Color.FromArgb(R, G, B)
                            UpdateHatnShirt(Color.FromArgb(R, G, B))
                            HatButton3.PerformClick()
                        Case "07EC98"
                            HairButton1.BackColor = Color.FromArgb(R, G, B)
                            HairButton1.PerformClick()
                        Case "07ECA0"
                            HairButton3.BackColor = Color.FromArgb(R, G, B)
                            UpdateHair(Color.FromArgb(R, G, B))
                            HairButton3.PerformClick()
                        Case "07EC80"
                            SkinButton1.BackColor = Color.FromArgb(R, G, B)
                            SkinButton1.PerformClick()
                        Case "07EC88"
                            SkinButton3.BackColor = Color.FromArgb(R, G, B)
                            UpdateSkin(Color.FromArgb(R, G, B))
                            SkinButton3.PerformClick()
                        Case "07EC20"
                            PantsButton1.BackColor = Color.FromArgb(R, G, B)
                            PantsButton1.PerformClick()
                        Case "07EC28"
                            PantsButton3.BackColor = Color.FromArgb(R, G, B)
                            UpdateOveralls(Color.FromArgb(R, G, B))
                            PantsButton3.PerformClick()
                        Case "07EC50"
                            GlovesButton1.BackColor = Color.FromArgb(R, G, B)
                            GlovesButton1.PerformClick()
                        Case "07EC58"
                            GlovesButton3.BackColor = Color.FromArgb(R, G, B)
                            UpdateGloves(Color.FromArgb(R, G, B))
                            GlovesButton3.PerformClick()
                        Case "07EC68"
                            ShoesButton1.BackColor = Color.FromArgb(R, G, B)
                            ShoesButton1.PerformClick()
                        Case "07EC70"
                            ShoesButton3.BackColor = Color.FromArgb(R, G, B)
                            UpdateShoes(Color.FromArgb(R, G, B))
                            ShoesButton3.PerformClick()
                    End Select
                Next

                MarioSprite.Refresh()
                IsSettingAllColors = False
            Catch ex As Exception
                MsgBox(CCSImportError & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub ExportColorCode(sender As Object, e As EventArgs) Handles ExportCCButton.Click
        If CCCopyPaste IsNot Nothing AndAlso CCCopyPaste.IsDisposed = False Then
            CCCopyPaste.Close()
        End If

        Dim generatedCode As String = ""
        For Each control As Control In Controls
            If TypeOf control Is Button Then
                Dim button As Button = DirectCast(control, Button)
                If button.Text = "" Then
                    Dim addressToWrite(1) As String
                    Select Case button.Name
                        Case "HatButton1"
                            addressToWrite(0) = "07EC38"
                            addressToWrite(1) = "07EC3A"
                        Case "HatButton2"
                            addressToWrite(0) = "07EC3C"
                            addressToWrite(1) = "07EC3E"
                        Case "HatButton3"
                            addressToWrite(0) = "07EC40"
                            addressToWrite(1) = "07EC42"
                        Case "HatButton4"
                            addressToWrite(0) = "07EC44"
                            addressToWrite(1) = "07EC46"
                        Case "HairButton1"
                            addressToWrite(0) = "07EC98"
                            addressToWrite(1) = "07EC9A"
                        Case "HairButton2"
                            addressToWrite(0) = "07EC9C"
                            addressToWrite(1) = "07EC9E"
                        Case "HairButton3"
                            addressToWrite(0) = "07ECA0"
                            addressToWrite(1) = "07ECA2"
                        Case "HairButton4"
                            addressToWrite(0) = "07ECA4"
                            addressToWrite(1) = "07ECA6"
                        Case "SkinButton1"
                            addressToWrite(0) = "07EC80"
                            addressToWrite(1) = "07EC82"
                        Case "SkinButton2"
                            addressToWrite(0) = "07EC84"
                            addressToWrite(1) = "07EC86"
                        Case "SkinButton3"
                            addressToWrite(0) = "07EC88"
                            addressToWrite(1) = "07EC8A"
                        Case "SkinButton4"
                            addressToWrite(0) = "07EC8C"
                            addressToWrite(1) = "07EC8E"
                        Case "PantsButton1"
                            addressToWrite(0) = "07EC20"
                            addressToWrite(1) = "07EC22"
                        Case "PantsButton2"
                            addressToWrite(0) = "07EC24"
                            addressToWrite(1) = "07EC26"
                        Case "PantsButton3"
                            addressToWrite(0) = "07EC28"
                            addressToWrite(1) = "07EC2A"
                        Case "PantsButton4"
                            addressToWrite(0) = "07EC2C"
                            addressToWrite(1) = "07EC2E"
                        Case "GlovesButton1"
                            addressToWrite(0) = "07EC50"
                            addressToWrite(1) = "07EC52"
                        Case "GlovesButton2"
                            addressToWrite(0) = "07EC54"
                            addressToWrite(1) = "07EC56"
                        Case "GlovesButton3"
                            addressToWrite(0) = "07EC58"
                            addressToWrite(1) = "07EC5A"
                        Case "GlovesButton4"
                            addressToWrite(0) = "07EC5C"
                            addressToWrite(1) = "07EC5E"
                        Case "ShoesButton1"
                            addressToWrite(0) = "07EC68"
                            addressToWrite(1) = "07EC6A"
                        Case "ShoesButton2"
                            addressToWrite(0) = "07EC6C"
                            addressToWrite(1) = "07EC6E"
                        Case "ShoesButton3"
                            addressToWrite(0) = "07EC70"
                            addressToWrite(1) = "07EC72"
                        Case "ShoesButton4"
                            addressToWrite(0) = "07EC74"
                            addressToWrite(1) = "07EC76"
                    End Select
                    generatedCode += "81" & addressToWrite(0) & " " & FixZeroHexByte(Hex(button.BackColor.R)) & FixZeroHexByte(Hex(button.BackColor.G)) & vbCrLf
                    generatedCode += "81" & addressToWrite(1) & " " & FixZeroHexByte(Hex(button.BackColor.B)) & "00" & vbCrLf
                    'Dim bytes As String = colorData.Substring(6, 2) & colorData.Substring(4, 2) & colorData.Substring(2, 2) & colorData.Substring(0, 2)
                End If
            End If
        Next
        CCCopyPaste = New ColorCodeCopyPasteForm(True, Me, generatedCode)
        CCCopyPaste.Show()
    End Sub

    Private Sub MarioSprite_DoubleClick(sender As Object, e As EventArgs) Handles MarioSprite.DoubleClick
        If (ShadowMode = 0) Then
            cycleColors = Not cycleColors
        Else
            cycleShadows = Not cycleShadows
        End If
    End Sub

    Private Sub UpdateHatnShirt(c As Color)
        hatColorMap.NewColor = c
    End Sub

    Private Sub UpdateOveralls(c As Color)
        pantsColorMap.NewColor = c
    End Sub

    Private Sub UpdateSkin(c As Color)
        skinColorMap.NewColor = c
    End Sub

    Private Sub UpdateGloves(c As Color)
        glovesColorMap.NewColor = c
    End Sub

    Private Sub UpdateShoes(c As Color)
        shoesColorMap.NewColor = c
    End Sub

    Private Sub UpdateHair(c As Color)
        hairColorMap.NewColor = c
    End Sub

    Private Sub ChangeModeBtn_Click(sender As Object, e As EventArgs) Handles ChangeModeBtn.Click
        If ShadowMode = 0 Then
            ChangeModeBtn.Text = My.Resources.CCS_ColorMode
            ShadingSliderX.Visible = True
            ShadingSliderY.Visible = True
            ShadingSliderZ.Visible = True
            SX_lb.Visible = True
            SY_lb.Visible = True
            SZ_lb.Visible = True
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Left_lb.Visible = True
            High_lb.Visible = True
            Low_lb.Visible = True
            Right_lb.Visible = True
            Back_lb.Visible = True
            Front_lb.Visible = True
            SkinButton1.Visible = False
            SkinButton3.Visible = False
            HairButton1.Visible = False
            HairButton3.Visible = False
            ShoesButton1.Visible = False
            ShoesButton3.Visible = False
            HatButton1.Visible = False
            HatButton3.Visible = False
            GlovesButton1.Visible = False
            GlovesButton3.Visible = False
            PantsButton1.Visible = False
            PantsButton3.Visible = False
            DefaultButton.Visible = False
            ImportCCButton.Visible = False
            LoadRamButton.Visible = False
            ExportCCButton.Visible = False
            SpecificZ_UpDown.Visible = True
            SpecificX_UpDown.Visible = True
            SpecificY_UpDown.Visible = True
            RMZ_X.Visible = True
            RMZ_Y.Visible = True
            RMZ_Z.Visible = True
            RandomizerY1.Visible = True
            RandomizerX1.Visible = True
            RandomizerZ1.Visible = True
            RandomizerX2.Visible = True
            RandomizerY2.Visible = True
            RandomizerZ2.Visible = True
            ShadowMode = 1
        Else
            ChangeModeBtn.Text = My.Resources.CCS_ShadingMode
            ShadingSliderX.Visible = False
            ShadingSliderY.Visible = False
            ShadingSliderZ.Visible = False
            SX_lb.Visible = False
            SY_lb.Visible = False
            SZ_lb.Visible = False
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Left_lb.Visible = False
            High_lb.Visible = False
            Low_lb.Visible = False
            Right_lb.Visible = False
            Back_lb.Visible = False
            Front_lb.Visible = False
            SkinButton1.Visible = True
            SkinButton3.Visible = True
            HairButton1.Visible = True
            HairButton3.Visible = True
            ShoesButton1.Visible = True
            ShoesButton3.Visible = True
            HatButton1.Visible = True
            HatButton3.Visible = True
            GlovesButton1.Visible = True
            GlovesButton3.Visible = True
            PantsButton1.Visible = True
            PantsButton3.Visible = True
            DefaultButton.Visible = True
            ImportCCButton.Visible = True
            LoadRamButton.Visible = True
            ExportCCButton.Visible = True
            SpecificZ_UpDown.Visible = False
            SpecificX_UpDown.Visible = False
            SpecificY_UpDown.Visible = False
            RMZ_X.Visible = False
            RMZ_Y.Visible = False
            RMZ_Z.Visible = False
            RandomizerY1.Visible = False
            RandomizerX1.Visible = False
            RandomizerZ1.Visible = False
            RandomizerX2.Visible = False
            RandomizerY2.Visible = False
            RandomizerZ2.Visible = False
            ShadowMode = 0
        End If
    End Sub

    Private Sub SpecificX_UpDown_ValueChanged(sender As Object, e As EventArgs) Handles SpecificX_UpDown.ValueChanged
        ShadingSliderX.Value = SpecificX_UpDown.Value
    End Sub

    Private Sub SpecificY_UpDown_ValueChanged(sender As Object, e As EventArgs) Handles SpecificY_UpDown.ValueChanged
        ShadingSliderY.Value = SpecificY_UpDown.Value
    End Sub

    Private Sub SpecificZ_UpDown_ValueChanged(sender As Object, e As EventArgs) Handles SpecificZ_UpDown.ValueChanged
        ShadingSliderZ.Value = SpecificZ_UpDown.Value
    End Sub

    Private Sub RandomizerX1_ValueChanged(sender As Object, e As EventArgs) Handles RandomizerX1.ValueChanged
        If RandomizerX1.Value >= RandomizerX2.Value Then
            RandomizerX1.Value = RandomizerX2.Value - 1
        End If
    End Sub

    Private Sub RandomizerX2_ValueChanged(sender As Object, e As EventArgs) Handles RandomizerX2.ValueChanged
        If RandomizerX2.Value <= RandomizerX1.Value Then
            RandomizerX2.Value = RandomizerX1.Value + 1
        End If
    End Sub

    Private Sub RandomizerY1_ValueChanged(sender As Object, e As EventArgs) Handles RandomizerY1.ValueChanged
        If RandomizerY1.Value >= RandomizerY2.Value Then
            RandomizerY1.Value = RandomizerY2.Value - 1
        End If
    End Sub

    Private Sub RandomizerY2_ValueChanged(sender As Object, e As EventArgs) Handles RandomizerY2.ValueChanged
        If RandomizerY2.Value <= RandomizerY1.Value Then
            RandomizerY2.Value = RandomizerY1.Value + 1
        End If
    End Sub

    Private Sub RandomizerZ1_ValueChanged(sender As Object, e As EventArgs) Handles RandomizerZ1.ValueChanged
        If RandomizerZ1.Value >= RandomizerZ2.Value Then
            RandomizerZ1.Value = RandomizerZ2.Value - 1
        End If
    End Sub

    Private Sub RandomizerZ2_ValueChanged(sender As Object, e As EventArgs) Handles RandomizerZ2.ValueChanged
        If RandomizerZ2.Value <= RandomizerZ1.Value Then
            RandomizerZ2.Value = RandomizerZ1.Value + 1
        End If
    End Sub
End Class