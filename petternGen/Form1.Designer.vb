<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.add1 = New System.Windows.Forms.Button()
        Me.add2 = New System.Windows.Forms.Button()
        Me.add3 = New System.Windows.Forms.Button()
        Me.clear1 = New System.Windows.Forms.Button()
        Me.clear2 = New System.Windows.Forms.Button()
        Me.clear3 = New System.Windows.Forms.Button()
        Me.remove1 = New System.Windows.Forms.Button()
        Me.remove2 = New System.Windows.Forms.Button()
        Me.remove3 = New System.Windows.Forms.Button()
        Me.log = New System.Windows.Forms.TextBox()
        Me.logContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.クリアToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.全て選択AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.先頭へToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.末尾へEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.genResult = New System.Windows.Forms.TextBox()
        Me.gen = New System.Windows.Forms.Button()
        Me.allClear = New System.Windows.Forms.Button()
        Me.b1to3 = New System.Windows.Forms.Button()
        Me.b2to1 = New System.Windows.Forms.Button()
        Me.b1to2 = New System.Windows.Forms.Button()
        Me.b3to2 = New System.Windows.Forms.Button()
        Me.b2to3 = New System.Windows.Forms.Button()
        Me.b3to1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.logContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(29, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(86, 100)
        Me.ListBox1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ListBox1, "ダブルクリックで項目を入力エリアに戻します")
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(145, 27)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(86, 100)
        Me.ListBox2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ListBox2, "ダブルクリックで項目を入力エリアに戻します")
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 12
        Me.ListBox3.Location = New System.Drawing.Point(263, 27)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(86, 100)
        Me.ListBox3.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ListBox3, "ダブルクリックで項目を入力エリアに戻します")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1文字"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2文字"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3文字"
        '
        'txt1
        '
        Me.txt1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt1.Location = New System.Drawing.Point(29, 135)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(56, 19)
        Me.txt1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txt1, "登録する文字を入力します")
        '
        'txt2
        '
        Me.txt2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt2.Location = New System.Drawing.Point(145, 133)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(57, 19)
        Me.txt2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txt2, "登録する文字を入力します")
        '
        'txt3
        '
        Me.txt3.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt3.Location = New System.Drawing.Point(263, 133)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(56, 19)
        Me.txt3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txt3, "登録する文字を入力します")
        '
        'add1
        '
        Me.add1.Location = New System.Drawing.Point(89, 133)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(24, 21)
        Me.add1.TabIndex = 9
        Me.add1.Text = "+"
        Me.ToolTip1.SetToolTip(Me.add1, "入力した文字を登録します")
        Me.add1.UseVisualStyleBackColor = True
        '
        'add2
        '
        Me.add2.Location = New System.Drawing.Point(208, 132)
        Me.add2.Name = "add2"
        Me.add2.Size = New System.Drawing.Size(24, 21)
        Me.add2.TabIndex = 10
        Me.add2.Text = "+"
        Me.ToolTip1.SetToolTip(Me.add2, "入力した文字を登録します")
        Me.add2.UseVisualStyleBackColor = True
        '
        'add3
        '
        Me.add3.Location = New System.Drawing.Point(325, 131)
        Me.add3.Name = "add3"
        Me.add3.Size = New System.Drawing.Size(24, 21)
        Me.add3.TabIndex = 11
        Me.add3.Text = "+"
        Me.ToolTip1.SetToolTip(Me.add3, "入力した文字を登録します")
        Me.add3.UseVisualStyleBackColor = True
        '
        'clear1
        '
        Me.clear1.Location = New System.Drawing.Point(89, 4)
        Me.clear1.Name = "clear1"
        Me.clear1.Size = New System.Drawing.Size(26, 20)
        Me.clear1.TabIndex = 15
        Me.clear1.Text = "C"
        Me.ToolTip1.SetToolTip(Me.clear1, "登録した項目を全て消します")
        Me.clear1.UseVisualStyleBackColor = True
        '
        'clear2
        '
        Me.clear2.Location = New System.Drawing.Point(205, 4)
        Me.clear2.Name = "clear2"
        Me.clear2.Size = New System.Drawing.Size(26, 20)
        Me.clear2.TabIndex = 16
        Me.clear2.Text = "C"
        Me.ToolTip1.SetToolTip(Me.clear2, "登録した項目を全て消します")
        Me.clear2.UseVisualStyleBackColor = True
        '
        'clear3
        '
        Me.clear3.Location = New System.Drawing.Point(323, 4)
        Me.clear3.Name = "clear3"
        Me.clear3.Size = New System.Drawing.Size(26, 20)
        Me.clear3.TabIndex = 17
        Me.clear3.Text = "C"
        Me.ToolTip1.SetToolTip(Me.clear3, "登録した項目を全て消します")
        Me.clear3.UseVisualStyleBackColor = True
        '
        'remove1
        '
        Me.remove1.Location = New System.Drawing.Point(89, 159)
        Me.remove1.Name = "remove1"
        Me.remove1.Size = New System.Drawing.Size(24, 21)
        Me.remove1.TabIndex = 12
        Me.remove1.Text = "-"
        Me.ToolTip1.SetToolTip(Me.remove1, "選択した項目を削除します")
        Me.remove1.UseVisualStyleBackColor = True
        '
        'remove2
        '
        Me.remove2.Location = New System.Drawing.Point(208, 159)
        Me.remove2.Name = "remove2"
        Me.remove2.Size = New System.Drawing.Size(24, 21)
        Me.remove2.TabIndex = 13
        Me.remove2.Text = "-"
        Me.ToolTip1.SetToolTip(Me.remove2, "選択した項目を削除します")
        Me.remove2.UseVisualStyleBackColor = True
        '
        'remove3
        '
        Me.remove3.Location = New System.Drawing.Point(325, 160)
        Me.remove3.Name = "remove3"
        Me.remove3.Size = New System.Drawing.Size(24, 21)
        Me.remove3.TabIndex = 14
        Me.remove3.Text = "-"
        Me.ToolTip1.SetToolTip(Me.remove3, "選択した項目を削除します")
        Me.remove3.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.log.BackColor = System.Drawing.SystemColors.Window
        Me.log.ContextMenuStrip = Me.logContext
        Me.log.ForeColor = System.Drawing.SystemColors.WindowText
        Me.log.Location = New System.Drawing.Point(-1, 187)
        Me.log.Multiline = True
        Me.log.Name = "log"
        Me.log.ReadOnly = True
        Me.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.log.Size = New System.Drawing.Size(331, 85)
        Me.log.TabIndex = 27
        '
        'logContext
        '
        Me.logContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.クリアToolStripMenuItem, Me.全て選択AToolStripMenuItem, Me.先頭へToolStripMenuItem, Me.末尾へEToolStripMenuItem})
        Me.logContext.Name = "logContext"
        Me.logContext.Size = New System.Drawing.Size(136, 92)
        '
        'クリアToolStripMenuItem
        '
        Me.クリアToolStripMenuItem.Name = "クリアToolStripMenuItem"
        Me.クリアToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.クリアToolStripMenuItem.Text = "クリア(&C)"
        '
        '全て選択AToolStripMenuItem
        '
        Me.全て選択AToolStripMenuItem.Name = "全て選択AToolStripMenuItem"
        Me.全て選択AToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.全て選択AToolStripMenuItem.Text = "全て選択(&A)"
        '
        '先頭へToolStripMenuItem
        '
        Me.先頭へToolStripMenuItem.Name = "先頭へToolStripMenuItem"
        Me.先頭へToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.先頭へToolStripMenuItem.Text = "先頭へ(&T)"
        '
        '末尾へEToolStripMenuItem
        '
        Me.末尾へEToolStripMenuItem.Name = "末尾へEToolStripMenuItem"
        Me.末尾へEToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.末尾へEToolStripMenuItem.Text = "末尾へ(&E)"
        '
        'genResult
        '
        Me.genResult.Location = New System.Drawing.Point(401, 39)
        Me.genResult.Multiline = True
        Me.genResult.Name = "genResult"
        Me.genResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.genResult.Size = New System.Drawing.Size(168, 233)
        Me.genResult.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.genResult, "ダブルクリックで全て選択します")
        '
        'gen
        '
        Me.gen.Location = New System.Drawing.Point(441, 4)
        Me.gen.Name = "gen"
        Me.gen.Size = New System.Drawing.Size(79, 31)
        Me.gen.TabIndex = 25
        Me.gen.Text = "生成"
        Me.ToolTip1.SetToolTip(Me.gen, "登録した項目の全ての組み合わせを生成します")
        Me.gen.UseVisualStyleBackColor = True
        '
        'allClear
        '
        Me.allClear.Location = New System.Drawing.Point(336, 242)
        Me.allClear.Name = "allClear"
        Me.allClear.Size = New System.Drawing.Size(59, 19)
        Me.allClear.TabIndex = 24
        Me.allClear.Text = "CCC"
        Me.ToolTip1.SetToolTip(Me.allClear, "1文字、2文字、3文字に登録した項目を全て消します")
        Me.allClear.UseVisualStyleBackColor = True
        '
        'b1to3
        '
        Me.b1to3.Location = New System.Drawing.Point(2, 74)
        Me.b1to3.Name = "b1to3"
        Me.b1to3.Size = New System.Drawing.Size(21, 19)
        Me.b1to3.TabIndex = 21
        Me.b1to3.Text = "<"
        Me.ToolTip1.SetToolTip(Me.b1to3, "選択した項目を左へ移動します")
        Me.b1to3.UseVisualStyleBackColor = True
        '
        'b2to1
        '
        Me.b2to1.Location = New System.Drawing.Point(119, 74)
        Me.b2to1.Name = "b2to1"
        Me.b2to1.Size = New System.Drawing.Size(20, 19)
        Me.b2to1.TabIndex = 22
        Me.b2to1.Text = "<"
        Me.ToolTip1.SetToolTip(Me.b2to1, "選択した項目を左へ移動します")
        Me.b2to1.UseVisualStyleBackColor = True
        '
        'b1to2
        '
        Me.b1to2.Location = New System.Drawing.Point(119, 47)
        Me.b1to2.Name = "b1to2"
        Me.b1to2.Size = New System.Drawing.Size(20, 19)
        Me.b1to2.TabIndex = 18
        Me.b1to2.Text = ">"
        Me.ToolTip1.SetToolTip(Me.b1to2, "選択した項目を右へ移動します")
        Me.b1to2.UseVisualStyleBackColor = True
        '
        'b3to2
        '
        Me.b3to2.Location = New System.Drawing.Point(237, 74)
        Me.b3to2.Name = "b3to2"
        Me.b3to2.Size = New System.Drawing.Size(20, 19)
        Me.b3to2.TabIndex = 23
        Me.b3to2.Text = "<"
        Me.ToolTip1.SetToolTip(Me.b3to2, "選択した項目を左へ移動します")
        Me.b3to2.UseVisualStyleBackColor = True
        '
        'b2to3
        '
        Me.b2to3.Location = New System.Drawing.Point(237, 47)
        Me.b2to3.Name = "b2to3"
        Me.b2to3.Size = New System.Drawing.Size(20, 19)
        Me.b2to3.TabIndex = 19
        Me.b2to3.Text = ">"
        Me.ToolTip1.SetToolTip(Me.b2to3, "選択した項目を右へ移動します")
        Me.b2to3.UseVisualStyleBackColor = True
        '
        'b3to1
        '
        Me.b3to1.Location = New System.Drawing.Point(354, 47)
        Me.b3to1.Name = "b3to1"
        Me.b3to1.Size = New System.Drawing.Size(20, 19)
        Me.b3to1.TabIndex = 20
        Me.b3to1.Text = ">"
        Me.ToolTip1.SetToolTip(Me.b3to1, "選択した項目を右へ移動します")
        Me.b3to1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 273)
        Me.Controls.Add(Me.b3to1)
        Me.Controls.Add(Me.b3to2)
        Me.Controls.Add(Me.b2to3)
        Me.Controls.Add(Me.b2to1)
        Me.Controls.Add(Me.b1to2)
        Me.Controls.Add(Me.b1to3)
        Me.Controls.Add(Me.allClear)
        Me.Controls.Add(Me.gen)
        Me.Controls.Add(Me.genResult)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.remove3)
        Me.Controls.Add(Me.remove2)
        Me.Controls.Add(Me.remove1)
        Me.Controls.Add(Me.clear3)
        Me.Controls.Add(Me.clear2)
        Me.Controls.Add(Me.clear1)
        Me.Controls.Add(Me.add3)
        Me.Controls.Add(Me.add2)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "petternGen"
        Me.logContext.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents add2 As System.Windows.Forms.Button
    Friend WithEvents add3 As System.Windows.Forms.Button
    Friend WithEvents clear1 As System.Windows.Forms.Button
    Friend WithEvents clear2 As System.Windows.Forms.Button
    Friend WithEvents clear3 As System.Windows.Forms.Button
    Friend WithEvents remove1 As System.Windows.Forms.Button
    Friend WithEvents remove2 As System.Windows.Forms.Button
    Friend WithEvents remove3 As System.Windows.Forms.Button
    Friend WithEvents log As System.Windows.Forms.TextBox
    Friend WithEvents genResult As System.Windows.Forms.TextBox
    Friend WithEvents gen As System.Windows.Forms.Button
    Friend WithEvents allClear As System.Windows.Forms.Button
    Friend WithEvents b1to3 As System.Windows.Forms.Button
    Friend WithEvents b2to1 As System.Windows.Forms.Button
    Friend WithEvents b1to2 As System.Windows.Forms.Button
    Friend WithEvents b3to2 As System.Windows.Forms.Button
    Friend WithEvents b2to3 As System.Windows.Forms.Button
    Friend WithEvents b3to1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents logContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents クリアToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全て選択AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 先頭へToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 末尾へEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
