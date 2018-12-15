<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cin = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tab = New System.Windows.Forms.TableLayoutPanel()
        Me.cell11 = New System.Windows.Forms.Label()
        Me.cell011 = New System.Windows.Forms.Label()
        Me.cell09 = New System.Windows.Forms.Label()
        Me.cell08 = New System.Windows.Forms.Label()
        Me.cell07 = New System.Windows.Forms.Label()
        Me.cell06 = New System.Windows.Forms.Label()
        Me.cell05 = New System.Windows.Forms.Label()
        Me.cell04 = New System.Windows.Forms.Label()
        Me.cell03 = New System.Windows.Forms.Label()
        Me.cell02 = New System.Windows.Forms.Label()
        Me.cell01 = New System.Windows.Forms.Label()
        Me.cell10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cell1 = New System.Windows.Forms.Label()
        Me.cell2 = New System.Windows.Forms.Label()
        Me.cell3 = New System.Windows.Forms.Label()
        Me.cell4 = New System.Windows.Forms.Label()
        Me.cell5 = New System.Windows.Forms.Label()
        Me.cell6 = New System.Windows.Forms.Label()
        Me.cell7 = New System.Windows.Forms.Label()
        Me.cell8 = New System.Windows.Forms.Label()
        Me.cell9 = New System.Windows.Forms.Label()
        Me.cell0 = New System.Windows.Forms.Label()
        Me.cell00 = New System.Windows.Forms.Label()
        Me.cell010 = New System.Windows.Forms.Label()
        Me.ServerState = New System.Windows.Forms.PictureBox()
        Me.EtudName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomClass = New System.Windows.Forms.Label()
        Me.Absence = New System.Windows.Forms.Label()
        Me.Tab.SuspendLayout()
        CType(Me.ServerState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(393, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "LogIn"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'cin
        '
        Me.cin.BackColor = System.Drawing.SystemColors.Menu
        Me.cin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cin.Location = New System.Drawing.Point(123, 15)
        Me.cin.Name = "cin"
        Me.cin.Size = New System.Drawing.Size(238, 20)
        Me.cin.TabIndex = 3
        Me.cin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.SystemColors.Menu
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pass.Location = New System.Drawing.Point(123, 50)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(238, 20)
        Me.pass.TabIndex = 4
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(15, 441)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(515, 20)
        Me.ProgBar.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Loading"
        '
        'Tab
        '
        Me.Tab.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.Tab.ColumnCount = 2
        Me.Tab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19531!))
        Me.Tab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80469!))
        Me.Tab.Controls.Add(Me.cell11, 0, 12)
        Me.Tab.Controls.Add(Me.cell011, 0, 12)
        Me.Tab.Controls.Add(Me.cell09, 1, 10)
        Me.Tab.Controls.Add(Me.cell08, 1, 9)
        Me.Tab.Controls.Add(Me.cell07, 1, 8)
        Me.Tab.Controls.Add(Me.cell06, 1, 7)
        Me.Tab.Controls.Add(Me.cell05, 1, 6)
        Me.Tab.Controls.Add(Me.cell04, 1, 5)
        Me.Tab.Controls.Add(Me.cell03, 1, 4)
        Me.Tab.Controls.Add(Me.cell02, 1, 3)
        Me.Tab.Controls.Add(Me.cell01, 1, 2)
        Me.Tab.Controls.Add(Me.cell10, 0, 11)
        Me.Tab.Controls.Add(Me.Label6, 0, 0)
        Me.Tab.Controls.Add(Me.Label7, 1, 0)
        Me.Tab.Controls.Add(Me.cell1, 0, 2)
        Me.Tab.Controls.Add(Me.cell2, 0, 3)
        Me.Tab.Controls.Add(Me.cell3, 0, 4)
        Me.Tab.Controls.Add(Me.cell4, 0, 5)
        Me.Tab.Controls.Add(Me.cell5, 0, 6)
        Me.Tab.Controls.Add(Me.cell6, 0, 7)
        Me.Tab.Controls.Add(Me.cell7, 0, 8)
        Me.Tab.Controls.Add(Me.cell8, 0, 9)
        Me.Tab.Controls.Add(Me.cell9, 0, 10)
        Me.Tab.Controls.Add(Me.cell0, 0, 1)
        Me.Tab.Controls.Add(Me.cell00, 1, 1)
        Me.Tab.Controls.Add(Me.cell010, 1, 11)
        Me.Tab.Location = New System.Drawing.Point(18, 107)
        Me.Tab.Name = "Tab"
        Me.Tab.RowCount = 13
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Tab.Size = New System.Drawing.Size(512, 309)
        Me.Tab.TabIndex = 10
        '
        'cell11
        '
        Me.cell11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell11.AutoSize = True
        Me.cell11.Location = New System.Drawing.Point(124, 286)
        Me.cell11.Name = "cell11"
        Me.cell11.Size = New System.Drawing.Size(10, 13)
        Me.cell11.TabIndex = 25
        Me.cell11.Text = " "
        Me.cell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell011
        '
        Me.cell011.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell011.AutoSize = True
        Me.cell011.Location = New System.Drawing.Point(378, 286)
        Me.cell011.Name = "cell011"
        Me.cell011.Size = New System.Drawing.Size(10, 13)
        Me.cell011.TabIndex = 24
        Me.cell011.Text = " "
        Me.cell011.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell09
        '
        Me.cell09.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell09.AutoSize = True
        Me.cell09.Location = New System.Drawing.Point(378, 236)
        Me.cell09.Name = "cell09"
        Me.cell09.Size = New System.Drawing.Size(10, 13)
        Me.cell09.TabIndex = 21
        Me.cell09.Text = " "
        Me.cell09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell08
        '
        Me.cell08.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell08.AutoSize = True
        Me.cell08.Location = New System.Drawing.Point(378, 213)
        Me.cell08.Name = "cell08"
        Me.cell08.Size = New System.Drawing.Size(10, 13)
        Me.cell08.TabIndex = 19
        Me.cell08.Text = " "
        Me.cell08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell07
        '
        Me.cell07.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell07.AutoSize = True
        Me.cell07.Location = New System.Drawing.Point(378, 190)
        Me.cell07.Name = "cell07"
        Me.cell07.Size = New System.Drawing.Size(10, 13)
        Me.cell07.TabIndex = 17
        Me.cell07.Text = " "
        Me.cell07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell06
        '
        Me.cell06.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell06.AutoSize = True
        Me.cell06.Location = New System.Drawing.Point(378, 167)
        Me.cell06.Name = "cell06"
        Me.cell06.Size = New System.Drawing.Size(10, 13)
        Me.cell06.TabIndex = 15
        Me.cell06.Text = " "
        Me.cell06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell05
        '
        Me.cell05.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell05.AutoSize = True
        Me.cell05.Location = New System.Drawing.Point(378, 144)
        Me.cell05.Name = "cell05"
        Me.cell05.Size = New System.Drawing.Size(10, 13)
        Me.cell05.TabIndex = 13
        Me.cell05.Text = " "
        Me.cell05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell04
        '
        Me.cell04.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell04.AutoSize = True
        Me.cell04.Location = New System.Drawing.Point(378, 121)
        Me.cell04.Name = "cell04"
        Me.cell04.Size = New System.Drawing.Size(10, 13)
        Me.cell04.TabIndex = 11
        Me.cell04.Text = " "
        Me.cell04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell03
        '
        Me.cell03.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell03.AutoSize = True
        Me.cell03.Location = New System.Drawing.Point(378, 98)
        Me.cell03.Name = "cell03"
        Me.cell03.Size = New System.Drawing.Size(10, 13)
        Me.cell03.TabIndex = 9
        Me.cell03.Text = " "
        Me.cell03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell02
        '
        Me.cell02.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell02.AutoSize = True
        Me.cell02.Location = New System.Drawing.Point(378, 75)
        Me.cell02.Name = "cell02"
        Me.cell02.Size = New System.Drawing.Size(10, 13)
        Me.cell02.TabIndex = 7
        Me.cell02.Text = " "
        Me.cell02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell01
        '
        Me.cell01.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell01.AutoSize = True
        Me.cell01.Location = New System.Drawing.Point(378, 52)
        Me.cell01.Name = "cell01"
        Me.cell01.Size = New System.Drawing.Size(10, 13)
        Me.cell01.TabIndex = 5
        Me.cell01.Text = " "
        Me.cell01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell10
        '
        Me.cell10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell10.AutoSize = True
        Me.cell10.Location = New System.Drawing.Point(124, 259)
        Me.cell10.Name = "cell10"
        Me.cell10.Size = New System.Drawing.Size(10, 13)
        Me.cell10.TabIndex = 22
        Me.cell10.Text = " "
        Me.cell10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Matieres"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(366, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Notes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell1
        '
        Me.cell1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell1.AutoSize = True
        Me.cell1.Location = New System.Drawing.Point(124, 52)
        Me.cell1.Name = "cell1"
        Me.cell1.Size = New System.Drawing.Size(10, 13)
        Me.cell1.TabIndex = 4
        Me.cell1.Text = " "
        Me.cell1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell2
        '
        Me.cell2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell2.AutoSize = True
        Me.cell2.Location = New System.Drawing.Point(124, 75)
        Me.cell2.Name = "cell2"
        Me.cell2.Size = New System.Drawing.Size(10, 13)
        Me.cell2.TabIndex = 6
        Me.cell2.Text = " "
        Me.cell2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell3
        '
        Me.cell3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell3.AutoSize = True
        Me.cell3.Location = New System.Drawing.Point(124, 98)
        Me.cell3.Name = "cell3"
        Me.cell3.Size = New System.Drawing.Size(10, 13)
        Me.cell3.TabIndex = 8
        Me.cell3.Text = " "
        Me.cell3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell4
        '
        Me.cell4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell4.AutoSize = True
        Me.cell4.Location = New System.Drawing.Point(124, 121)
        Me.cell4.Name = "cell4"
        Me.cell4.Size = New System.Drawing.Size(10, 13)
        Me.cell4.TabIndex = 10
        Me.cell4.Text = " "
        Me.cell4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell5
        '
        Me.cell5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell5.AutoSize = True
        Me.cell5.Location = New System.Drawing.Point(124, 144)
        Me.cell5.Name = "cell5"
        Me.cell5.Size = New System.Drawing.Size(10, 13)
        Me.cell5.TabIndex = 12
        Me.cell5.Text = " "
        Me.cell5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell6
        '
        Me.cell6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell6.AutoSize = True
        Me.cell6.Location = New System.Drawing.Point(124, 167)
        Me.cell6.Name = "cell6"
        Me.cell6.Size = New System.Drawing.Size(10, 13)
        Me.cell6.TabIndex = 14
        Me.cell6.Text = " "
        Me.cell6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell7
        '
        Me.cell7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell7.AutoSize = True
        Me.cell7.Location = New System.Drawing.Point(124, 190)
        Me.cell7.Name = "cell7"
        Me.cell7.Size = New System.Drawing.Size(10, 13)
        Me.cell7.TabIndex = 16
        Me.cell7.Text = " "
        Me.cell7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell8
        '
        Me.cell8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell8.AutoSize = True
        Me.cell8.Location = New System.Drawing.Point(124, 213)
        Me.cell8.Name = "cell8"
        Me.cell8.Size = New System.Drawing.Size(10, 13)
        Me.cell8.TabIndex = 18
        Me.cell8.Text = " "
        Me.cell8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell9
        '
        Me.cell9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell9.AutoSize = True
        Me.cell9.Location = New System.Drawing.Point(124, 236)
        Me.cell9.Name = "cell9"
        Me.cell9.Size = New System.Drawing.Size(10, 13)
        Me.cell9.TabIndex = 20
        Me.cell9.Text = " "
        Me.cell9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell0
        '
        Me.cell0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell0.AutoSize = True
        Me.cell0.Location = New System.Drawing.Point(124, 29)
        Me.cell0.Name = "cell0"
        Me.cell0.Size = New System.Drawing.Size(10, 13)
        Me.cell0.TabIndex = 2
        Me.cell0.Text = " "
        Me.cell0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell00
        '
        Me.cell00.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell00.AutoSize = True
        Me.cell00.Location = New System.Drawing.Point(378, 29)
        Me.cell00.Name = "cell00"
        Me.cell00.Size = New System.Drawing.Size(10, 13)
        Me.cell00.TabIndex = 3
        Me.cell00.Text = " "
        Me.cell00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cell010
        '
        Me.cell010.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cell010.AutoSize = True
        Me.cell010.Location = New System.Drawing.Point(378, 259)
        Me.cell010.Name = "cell010"
        Me.cell010.Size = New System.Drawing.Size(10, 13)
        Me.cell010.TabIndex = 23
        Me.cell010.Text = " "
        Me.cell010.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ServerState
        '
        Me.ServerState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ServerState.BackColor = System.Drawing.SystemColors.Control
        Me.ServerState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ServerState.Location = New System.Drawing.Point(18, 75)
        Me.ServerState.Name = "ServerState"
        Me.ServerState.Size = New System.Drawing.Size(23, 24)
        Me.ServerState.TabIndex = 11
        Me.ServerState.TabStop = False
        '
        'EtudName
        '
        Me.EtudName.AutoSize = True
        Me.EtudName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EtudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtudName.Location = New System.Drawing.Point(49, 78)
        Me.EtudName.Name = "EtudName"
        Me.EtudName.Size = New System.Drawing.Size(2, 19)
        Me.EtudName.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(3, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "INFO"
        '
        'nomClass
        '
        Me.nomClass.AutoSize = True
        Me.nomClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nomClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomClass.Location = New System.Drawing.Point(255, 79)
        Me.nomClass.Name = "nomClass"
        Me.nomClass.Size = New System.Drawing.Size(2, 19)
        Me.nomClass.TabIndex = 15
        '
        'Absence
        '
        Me.Absence.AutoSize = True
        Me.Absence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Absence.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Absence.Location = New System.Drawing.Point(400, 80)
        Me.Absence.Name = "Absence"
        Me.Absence.Size = New System.Drawing.Size(2, 19)
        Me.Absence.TabIndex = 16
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(543, 467)
        Me.Controls.Add(Me.Absence)
        Me.Controls.Add(Me.nomClass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EtudName)
        Me.Controls.Add(Me.ServerState)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.cin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = " Higher Institute of Information and Communication Technologies - ISTIC"
        Me.Tab.ResumeLayout(False)
        Me.Tab.PerformLayout()
        CType(Me.ServerState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cin As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents ProgBar As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Tab As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents EtudName As Label
    Friend WithEvents ServerState As PictureBox
    Friend WithEvents cell09 As Label
    Friend WithEvents cell08 As Label
    Friend WithEvents cell07 As Label
    Friend WithEvents cell06 As Label
    Friend WithEvents cell05 As Label
    Friend WithEvents cell04 As Label
    Friend WithEvents cell03 As Label
    Friend WithEvents cell02 As Label
    Friend WithEvents cell01 As Label
    Friend WithEvents cell00 As Label
    Friend WithEvents cell010 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cell11 As Label
    Friend WithEvents cell011 As Label
    Friend WithEvents cell10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cell1 As Label
    Friend WithEvents cell2 As Label
    Friend WithEvents cell3 As Label
    Friend WithEvents cell4 As Label
    Friend WithEvents cell5 As Label
    Friend WithEvents cell6 As Label
    Friend WithEvents cell7 As Label
    Friend WithEvents cell8 As Label
    Friend WithEvents cell9 As Label
    Friend WithEvents cell0 As Label
    Friend WithEvents nomClass As Label
    Friend WithEvents Absence As Label
End Class
