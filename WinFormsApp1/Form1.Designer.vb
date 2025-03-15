<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        output = New TextBox()
        history = New TextBox()
        btn0 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btndot = New Button()
        btnAdd = New Button()
        btnMinus = New Button()
        btnMult = New Button()
        btndiv = New Button()
        btnMod = New Button()
        btnExp = New Button()
        equal = New Button()
        clear = New Button()
        delete = New Button()
        squareroot = New Button()
        factorial = New Button()
        plusminus = New Button()
        pi = New Button()
        euler = New Button()
        abs = New Button()
        reciprocalofanumber = New Button()
        btnsquare = New Button()
        btnCube = New Button()
        btnCubeRoot = New Button()
        natural = New Button()
        btnLog = New Button()
        Button1 = New Button()
        past = New TextBox()
        leftparenthesis = New Button()
        rightparenthesis = New Button()
        btnClearHistory = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' output
        ' 
        output.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        output.Location = New Point(14, 14)
        output.Margin = New Padding(4, 3, 4, 3)
        output.Multiline = True
        output.Name = "output"
        output.Size = New Size(376, 220)
        output.TabIndex = 0
        output.TextAlign = HorizontalAlignment.Right
        ' 
        ' history
        ' 
        history.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        history.Location = New Point(447, 14)
        history.Margin = New Padding(4, 3, 4, 3)
        history.Multiline = True
        history.Name = "history"
        history.ReadOnly = True
        history.ScrollBars = ScrollBars.Vertical
        history.Size = New Size(367, 114)
        history.TabIndex = 1
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(206, 655)
        btn0.Margin = New Padding(4, 3, 4, 3)
        btn0.Name = "btn0"
        btn0.Size = New Size(88, 58)
        btn0.TabIndex = 2
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(109, 591)
        btn1.Margin = New Padding(4, 3, 4, 3)
        btn1.Name = "btn1"
        btn1.Size = New Size(88, 58)
        btn1.TabIndex = 3
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(206, 591)
        btn2.Margin = New Padding(4, 3, 4, 3)
        btn2.Name = "btn2"
        btn2.Size = New Size(88, 58)
        btn2.TabIndex = 4
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(302, 588)
        btn3.Margin = New Padding(4, 3, 4, 3)
        btn3.Name = "btn3"
        btn3.Size = New Size(88, 58)
        btn3.TabIndex = 5
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(110, 524)
        btn4.Margin = New Padding(4, 3, 4, 3)
        btn4.Name = "btn4"
        btn4.Size = New Size(88, 58)
        btn4.TabIndex = 6
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(206, 524)
        btn5.Margin = New Padding(4, 3, 4, 3)
        btn5.Name = "btn5"
        btn5.Size = New Size(88, 58)
        btn5.TabIndex = 7
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(302, 524)
        btn6.Margin = New Padding(4, 3, 4, 3)
        btn6.Name = "btn6"
        btn6.Size = New Size(88, 58)
        btn6.TabIndex = 8
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(110, 460)
        btn7.Margin = New Padding(4, 3, 4, 3)
        btn7.Name = "btn7"
        btn7.Size = New Size(88, 58)
        btn7.TabIndex = 9
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(206, 460)
        btn8.Margin = New Padding(4, 3, 4, 3)
        btn8.Name = "btn8"
        btn8.Size = New Size(88, 58)
        btn8.TabIndex = 10
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(302, 460)
        btn9.Margin = New Padding(4, 3, 4, 3)
        btn9.Name = "btn9"
        btn9.Size = New Size(88, 58)
        btn9.TabIndex = 11
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btndot
        ' 
        btndot.Location = New Point(302, 655)
        btndot.Margin = New Padding(4, 3, 4, 3)
        btndot.Name = "btndot"
        btndot.Size = New Size(88, 58)
        btndot.TabIndex = 12
        btndot.Text = "."
        btndot.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(398, 588)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(88, 58)
        btnAdd.TabIndex = 13
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnMinus
        ' 
        btnMinus.Location = New Point(398, 524)
        btnMinus.Margin = New Padding(4, 3, 4, 3)
        btnMinus.Name = "btnMinus"
        btnMinus.Size = New Size(88, 58)
        btnMinus.TabIndex = 14
        btnMinus.Text = "-"
        btnMinus.UseVisualStyleBackColor = True
        ' 
        ' btnMult
        ' 
        btnMult.Location = New Point(398, 460)
        btnMult.Margin = New Padding(4, 3, 4, 3)
        btnMult.Name = "btnMult"
        btnMult.Size = New Size(88, 58)
        btnMult.TabIndex = 15
        btnMult.Text = "*"
        btnMult.UseVisualStyleBackColor = True
        ' 
        ' btndiv
        ' 
        btndiv.Location = New Point(398, 396)
        btndiv.Margin = New Padding(4, 3, 4, 3)
        btndiv.Name = "btndiv"
        btndiv.Size = New Size(88, 58)
        btndiv.TabIndex = 16
        btndiv.Text = "/"
        btndiv.UseVisualStyleBackColor = True
        ' 
        ' btnMod
        ' 
        btnMod.Location = New Point(398, 332)
        btnMod.Margin = New Padding(4, 3, 4, 3)
        btnMod.Name = "btnMod"
        btnMod.Size = New Size(88, 58)
        btnMod.TabIndex = 17
        btnMod.Text = "Mod"
        btnMod.UseVisualStyleBackColor = True
        ' 
        ' btnExp
        ' 
        btnExp.Location = New Point(302, 332)
        btnExp.Margin = New Padding(4, 3, 4, 3)
        btnExp.Name = "btnExp"
        btnExp.Size = New Size(88, 58)
        btnExp.TabIndex = 18
        btnExp.Text = "Exp"
        btnExp.UseVisualStyleBackColor = True
        ' 
        ' equal
        ' 
        equal.Location = New Point(398, 652)
        equal.Margin = New Padding(4, 3, 4, 3)
        equal.Name = "equal"
        equal.Size = New Size(88, 58)
        equal.TabIndex = 19
        equal.Text = "="
        equal.UseVisualStyleBackColor = True
        ' 
        ' clear
        ' 
        clear.Location = New Point(302, 268)
        clear.Margin = New Padding(4, 3, 4, 3)
        clear.Name = "clear"
        clear.Size = New Size(88, 58)
        clear.TabIndex = 20
        clear.Text = "C"
        clear.UseVisualStyleBackColor = True
        ' 
        ' delete
        ' 
        delete.Location = New Point(398, 268)
        delete.Margin = New Padding(4, 3, 4, 3)
        delete.Name = "delete"
        delete.Size = New Size(88, 58)
        delete.TabIndex = 21
        delete.Text = "DEL"
        delete.UseVisualStyleBackColor = True
        ' 
        ' squareroot
        ' 
        squareroot.Location = New Point(14, 268)
        squareroot.Margin = New Padding(4, 3, 4, 3)
        squareroot.Name = "squareroot"
        squareroot.Size = New Size(88, 58)
        squareroot.TabIndex = 22
        squareroot.Text = "√"
        squareroot.UseVisualStyleBackColor = True
        ' 
        ' factorial
        ' 
        factorial.Location = New Point(302, 396)
        factorial.Margin = New Padding(4, 3, 4, 3)
        factorial.Name = "factorial"
        factorial.Size = New Size(88, 58)
        factorial.TabIndex = 23
        factorial.Text = "!"
        factorial.UseVisualStyleBackColor = True
        ' 
        ' plusminus
        ' 
        plusminus.Location = New Point(110, 655)
        plusminus.Margin = New Padding(4, 3, 4, 3)
        plusminus.Name = "plusminus"
        plusminus.Size = New Size(88, 58)
        plusminus.TabIndex = 24
        plusminus.Text = "+/-"
        plusminus.UseVisualStyleBackColor = True
        ' 
        ' pi
        ' 
        pi.Location = New Point(110, 268)
        pi.Margin = New Padding(4, 3, 4, 3)
        pi.Name = "pi"
        pi.Size = New Size(88, 58)
        pi.TabIndex = 25
        pi.Text = "π"
        pi.UseVisualStyleBackColor = True
        ' 
        ' euler
        ' 
        euler.Location = New Point(206, 268)
        euler.Margin = New Padding(4, 3, 4, 3)
        euler.Name = "euler"
        euler.Size = New Size(88, 58)
        euler.TabIndex = 26
        euler.Text = "e"
        euler.UseVisualStyleBackColor = True
        ' 
        ' abs
        ' 
        abs.Location = New Point(206, 332)
        abs.Margin = New Padding(4, 3, 4, 3)
        abs.Name = "abs"
        abs.Size = New Size(88, 58)
        abs.TabIndex = 27
        abs.Text = "|x|"
        abs.UseVisualStyleBackColor = True
        ' 
        ' reciprocalofanumber
        ' 
        reciprocalofanumber.Location = New Point(109, 332)
        reciprocalofanumber.Margin = New Padding(4, 3, 4, 3)
        reciprocalofanumber.Name = "reciprocalofanumber"
        reciprocalofanumber.Size = New Size(88, 58)
        reciprocalofanumber.TabIndex = 28
        reciprocalofanumber.Text = "1/x"
        reciprocalofanumber.UseVisualStyleBackColor = True
        ' 
        ' btnsquare
        ' 
        btnsquare.Location = New Point(13, 332)
        btnsquare.Margin = New Padding(4, 3, 4, 3)
        btnsquare.Name = "btnsquare"
        btnsquare.Size = New Size(88, 58)
        btnsquare.TabIndex = 29
        btnsquare.Text = "x²"
        btnsquare.UseVisualStyleBackColor = True
        ' 
        ' btnCube
        ' 
        btnCube.Location = New Point(14, 460)
        btnCube.Margin = New Padding(4, 3, 4, 3)
        btnCube.Name = "btnCube"
        btnCube.Size = New Size(88, 58)
        btnCube.TabIndex = 30
        btnCube.Text = "x³"
        btnCube.UseVisualStyleBackColor = True
        ' 
        ' btnCubeRoot
        ' 
        btnCubeRoot.Location = New Point(13, 396)
        btnCubeRoot.Margin = New Padding(4, 3, 4, 3)
        btnCubeRoot.Name = "btnCubeRoot"
        btnCubeRoot.Size = New Size(88, 58)
        btnCubeRoot.TabIndex = 31
        btnCubeRoot.Text = "∛x"
        btnCubeRoot.UseVisualStyleBackColor = True
        ' 
        ' natural
        ' 
        natural.Location = New Point(14, 655)
        natural.Margin = New Padding(4, 3, 4, 3)
        natural.Name = "natural"
        natural.Size = New Size(88, 58)
        natural.TabIndex = 32
        natural.Text = "ln"
        natural.UseVisualStyleBackColor = True
        ' 
        ' btnLog
        ' 
        btnLog.Location = New Point(13, 591)
        btnLog.Margin = New Padding(4, 3, 4, 3)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(88, 58)
        btnLog.TabIndex = 33
        btnLog.Text = "log10"
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(14, 524)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 58)
        Button1.TabIndex = 34
        Button1.Text = "x³"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' past
        ' 
        past.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        past.Location = New Point(520, 201)
        past.Margin = New Padding(4, 3, 4, 3)
        past.Multiline = True
        past.Name = "past"
        past.Size = New Size(294, 468)
        past.TabIndex = 35
        past.TextAlign = HorizontalAlignment.Right
        ' 
        ' leftparenthesis
        ' 
        leftparenthesis.Location = New Point(111, 396)
        leftparenthesis.Name = "leftparenthesis"
        leftparenthesis.Size = New Size(87, 58)
        leftparenthesis.TabIndex = 37
        leftparenthesis.Text = "("
        leftparenthesis.UseVisualStyleBackColor = True
        ' 
        ' rightparenthesis
        ' 
        rightparenthesis.Location = New Point(208, 396)
        rightparenthesis.Name = "rightparenthesis"
        rightparenthesis.Size = New Size(87, 58)
        rightparenthesis.TabIndex = 39
        rightparenthesis.Text = ")"
        rightparenthesis.UseVisualStyleBackColor = True
        ' 
        ' btnClearHistory
        ' 
        btnClearHistory.Location = New Point(520, 675)
        btnClearHistory.Name = "btnClearHistory"
        btnClearHistory.Size = New Size(294, 38)
        btnClearHistory.TabIndex = 40
        btnClearHistory.Text = "Clear History"
        btnClearHistory.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 41
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(659, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 37)
        Label2.TabIndex = 42
        Label2.Text = "HISTORY"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(866, 725)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnClearHistory)
        Controls.Add(rightparenthesis)
        Controls.Add(leftparenthesis)
        Controls.Add(past)
        Controls.Add(Button1)
        Controls.Add(btnLog)
        Controls.Add(natural)
        Controls.Add(btnCubeRoot)
        Controls.Add(btnCube)
        Controls.Add(btnsquare)
        Controls.Add(reciprocalofanumber)
        Controls.Add(abs)
        Controls.Add(euler)
        Controls.Add(pi)
        Controls.Add(plusminus)
        Controls.Add(factorial)
        Controls.Add(squareroot)
        Controls.Add(delete)
        Controls.Add(clear)
        Controls.Add(equal)
        Controls.Add(btnExp)
        Controls.Add(btnMod)
        Controls.Add(btndiv)
        Controls.Add(btnMult)
        Controls.Add(btnMinus)
        Controls.Add(btnAdd)
        Controls.Add(btndot)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btn0)
        Controls.Add(history)
        Controls.Add(output)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents output As TextBox
    Friend WithEvents history As TextBox
    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btndot As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnExp As Button
    Friend WithEvents equal As Button
    Friend WithEvents clear As Button
    Friend WithEvents delete As Button
    Friend WithEvents squareroot As Button
    Friend WithEvents factorial As Button
    Friend WithEvents plusminus As Button
    Friend WithEvents pi As Button
    Friend WithEvents euler As Button
    Friend WithEvents abs As Button
    Friend WithEvents reciprocalofanumber As Button
    Friend WithEvents btnsquare As Button
    Friend WithEvents btnCube As Button
    Friend WithEvents btnCubeRoot As Button
    Friend WithEvents natural As Button
    Friend WithEvents btnLog As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents past As TextBox
    Friend WithEvents leftparenthesis As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents rightparenthesis As Button
    Friend WithEvents btnClearHistory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class