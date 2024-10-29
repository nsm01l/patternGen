Public Class Form1

    ''' <summary>
    ''' 初期動作
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        log.Text = "petternGen started."
        txt1.Focus()
    End Sub

    ''' <summary>
    ''' 追加ボタン1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        With txt1
            .Text = .Text.Trim
            If (.Text.Length = 0) Then
                addLog("入力してください")
                Exit Sub
            End If
            If (Not ListBox1.Items.Contains(.Text)) Then
                ListBox1.Items.Add(.Text)
                addLog("追加しました")
                .Text = ""
            Else
                addLog("重複しています")
            End If
            .Focus()
        End With
    End Sub

    ''' <summary>
    ''' 追加ボタン2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub add2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add2.Click
        With txt2
            .Text = .Text.Trim
            If (.Text.Length = 0) Then
                addLog("入力してください")
                Exit Sub
            End If
            If (Not ListBox2.Items.Contains(.Text)) Then
                ListBox2.Items.Add(.Text)
                addLog("追加しました")
                .Text = ""
            Else
                addLog("重複しています")
            End If
            .Focus()
        End With
    End Sub

    ''' <summary>
    ''' 追加ボタン3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub add3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add3.Click
        With txt3
            .Text = .Text.Trim
            If (.Text.Length = 0) Then
                addLog("入力してください")
                Exit Sub
            End If
            If (Not ListBox3.Items.Contains(.Text)) Then
                ListBox3.Items.Add(.Text)
                addLog("追加しました")
                .Text = ""
            Else
                addLog("重複しています")
            End If
            .Focus()
        End With
    End Sub

    ''' <summary>
    ''' クリア1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear1.Click
        ListBox1.Items.Clear()
        addLog("登録内容をすべて消しました")
    End Sub

    ''' <summary>
    ''' クリア2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear2.Click
        ListBox2.Items.Clear()
        addLog("登録内容をすべて消しました")
    End Sub

    ''' <summary>
    ''' クリア3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clear3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear3.Click
        ListBox3.Items.Clear()
        addLog("登録内容をすべて消しました")
    End Sub

    ''' <summary>
    ''' 選択削除1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub remove1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remove1.Click
        With ListBox1
            If (.SelectedIndex = -1) Then
                addLog("選択してください")
                Exit Sub
            Else
                .Items.RemoveAt(.SelectedIndex)
            End If
        End With
    End Sub

    ''' <summary>
    ''' 選択削除2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub remove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remove2.Click
        With ListBox2
            If (.SelectedIndex = -1) Then
                addLog("選択してください")
                Exit Sub
            Else
                .Items.RemoveAt(.SelectedIndex)
            End If
        End With
    End Sub

    ''' <summary>
    ''' 選択削除3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub remove3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remove3.Click
        With ListBox3
            If (.SelectedIndex = -1) Then
                addLog("選択してください")
                Exit Sub
            Else
                .Items.RemoveAt(.SelectedIndex)
            End If
        End With
    End Sub

    ''' <summary>
    ''' ログ追加
    ''' </summary>
    ''' <param name="txt"></param>
    Private Sub addLog(ByVal txt As String)
        log.Text &= vbCrLf & txt
    End Sub

    ''' <summary>
    ''' ログ表示位置の変更
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub log_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles log.TextChanged
        With log
            .SelectionStart = .Text.Length
            .ScrollToCaret()
        End With
    End Sub

    ''' <summary>
    ''' txt1のキーが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then
            e.Handled = True
            add1_Click(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' txt2のキーが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then
            e.Handled = True
            add2_Click(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' txt3のキーが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then
            e.Handled = True
            add3_Click(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' 生成ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub gen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gen.Click
        Dim x(), y(), z() As String
        Dim xs, ys, zs As Integer

        xs = ListBox1.Items.Count
        x = New String(xs) {}
        For i As Integer = 0 To xs - 1
            x(i) = ListBox1.Items.Item(i)
        Next i

        ys = ListBox2.Items.Count
        y = New String(ys) {}
        For i As Integer = 0 To ys - 1
            y(i) = ListBox2.Items.Item(i)
        Next i

        zs = ListBox3.Items.Count
        z = New String(zs) {}
        For i As Integer = 0 To zs - 1
            z(i) = ListBox3.Items.Item(i)
        Next i

        '生成
        genResult.Text = ""
        If (xs = 0) Then
            addLog("1文字目に何かを入力してください")
            Exit Sub
        ElseIf (zs = 0 And ys = 0) Then
            For i As Integer = 0 To xs - 1
                genResult.Text &= x(i) & vbCrLf
            Next i
        ElseIf (zs = 0) Then
            For i As Integer = 0 To xs - 1
                For j As Integer = 0 To ys - 1
                    genResult.Text &= x(i) & y(j) & vbCrLf
                Next j
            Next i
        Else
            For i As Integer = 0 To xs - 1
                For j As Integer = 0 To ys - 1
                    For k As Integer = 0 To zs - 1
                        genResult.Text &= x(i) & y(j) & z(k) & vbCrLf
                    Next k
                Next j
            Next i
        End If
        addLog("生成しました")
    End Sub

    ''' <summary>
    ''' genResultがダブルクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub genResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles genResult.DoubleClick
        With genResult
            .SelectionStart = 0
            .SelectionLength = .Text.Length
        End With
    End Sub

    ''' <summary>
    ''' CCCボタンが押された
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub allClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allClear.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        addLog("全ての登録を削除しました")
    End Sub

    ''' <summary>
    ''' ListBox1がダブルクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        With ListBox1
            If (.SelectedIndex = -1) Then
                addLog("選択してください")
                Exit Sub
            End If

            '選択項目をTextBoxに戻す
            txt1.Text = .Items.Item(.SelectedIndex)
            .Items.RemoveAt(.SelectedIndex)

            txt1.Focus()
            addLog("選択項目を入力エリアに戻しました")
        End With
    End Sub

    ''' <summary>
    ''' ListBox2がダブルクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        With ListBox2
            If (.SelectedIndex = -1) Then
                addLog("選択してください")
                Exit Sub
            End If

            '選択項目をTextBoxに戻す
            txt2.Text = .Items.Item(.SelectedIndex)
            .Items.RemoveAt(.SelectedIndex)

            txt2.Focus()
            addLog("選択項目を入力エリアに戻しました")
        End With
    End Sub

    ''' <summary>
    ''' ListBox3がダブルクリックされた
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox3.DoubleClick
        With ListBox3
            If (.SelectedIndex = -1) Then
                addLog("選択してください")
                Exit Sub
            End If

            '選択項目をTextBoxに戻す
            txt3.Text = .Items.Item(.SelectedIndex)
            .Items.RemoveAt(.SelectedIndex)

            txt3.Focus()
            addLog("選択項目を入力エリアに戻しました")
        End With
    End Sub

    ''' <summary>
    ''' 1to2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub b1to2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1to2.Click
        moveItem(ListBox1, ListBox2)
    End Sub

    ''' <summary>
    ''' 2to1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub b2to1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2to1.Click
        moveItem(ListBox2, ListBox1)
    End Sub

    ''' <summary>
    ''' 1to3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub b1to3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1to3.Click
        moveItem(ListBox1, ListBox3)
    End Sub

    ''' <summary>
    ''' 3to1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub b3to1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3to1.Click
        moveItem(ListBox3, ListBox1)
    End Sub

    ''' <summary>
    ''' 2to3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub b2to3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2to3.Click
        moveItem(ListBox2, ListBox3)
    End Sub

    ''' <summary>
    ''' 3to2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub b3to2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3to2.Click
        moveItem(ListBox3, ListBox2)
    End Sub

    ''' <summary>
    ''' 選択項目を移動する
    ''' </summary>
    ''' <param name="s"></param>
    ''' <param name="r"></param>
    Private Sub moveItem(ByVal s As ListBox, ByVal r As ListBox)
        With s
            If (.SelectedIndex = -1) Then
                addLog("選択してください")
                Exit Sub
            End If

            r.Items.Add(.Items.Item(.SelectedIndex))
            .Items.RemoveAt(.SelectedIndex)
            addLog("選択項目を移動しました")
        End With
    End Sub

    ''' <summary>
    ''' log クリア
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub クリアToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles クリアToolStripMenuItem.Click
        log.Text = ""
    End Sub

    ''' <summary>
    ''' log 全て選択
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 全て選択AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全て選択AToolStripMenuItem.Click
        With log
            .SelectionStart = 0
            .SelectionLength = .Text.Length
            .Focus()
        End With
    End Sub

    ''' <summary>
    ''' log 先頭へ移動
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 先頭へToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 先頭へToolStripMenuItem.Click
        With log
            .SelectionStart = 0
            .SelectionLength = 0
            .ScrollToCaret()
        End With
    End Sub

    ''' <summary>
    ''' log 末尾へ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 末尾へEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 末尾へEToolStripMenuItem.Click
        With log
            .SelectionStart = .Text.Length
            .SelectionLength = 0
            .ScrollToCaret()
        End With
    End Sub
End Class
