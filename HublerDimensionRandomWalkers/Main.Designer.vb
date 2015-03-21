<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGeneratePoints = New System.Windows.Forms.Button()
        Me.numDimensions = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numNumberOfPoints = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numNumberOfWalkers = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numMaximumSteps = New System.Windows.Forms.NumericUpDown()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.picWalker = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numEpsilonValue = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numStartingRadius = New System.Windows.Forms.NumericUpDown()
        Me.chkSelfAvoidingWalkers = New System.Windows.Forms.CheckBox()
        Me.chkStartinPointOnRadius = New System.Windows.Forms.CheckBox()
        CType(Me.numDimensions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNumberOfPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNumberOfWalkers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaximumSteps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWalker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEpsilonValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStartingRadius, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGeneratePoints
        '
        Me.btnGeneratePoints.Location = New System.Drawing.Point(12, 180)
        Me.btnGeneratePoints.Name = "btnGeneratePoints"
        Me.btnGeneratePoints.Size = New System.Drawing.Size(75, 38)
        Me.btnGeneratePoints.TabIndex = 8
        Me.btnGeneratePoints.Text = "Generate Points"
        Me.btnGeneratePoints.UseVisualStyleBackColor = True
        '
        'numDimensions
        '
        Me.numDimensions.DecimalPlaces = 1
        Me.numDimensions.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numDimensions.Location = New System.Drawing.Point(12, 28)
        Me.numDimensions.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numDimensions.Name = "numDimensions"
        Me.numDimensions.Size = New System.Drawing.Size(47, 20)
        Me.numDimensions.TabIndex = 0
        Me.numDimensions.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dimensions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of Points"
        '
        'numNumberOfPoints
        '
        Me.numNumberOfPoints.Location = New System.Drawing.Point(80, 28)
        Me.numNumberOfPoints.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.numNumberOfPoints.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNumberOfPoints.Name = "numNumberOfPoints"
        Me.numNumberOfPoints.Size = New System.Drawing.Size(85, 20)
        Me.numNumberOfPoints.TabIndex = 1
        Me.numNumberOfPoints.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number of Walkers:"
        '
        'numNumberOfWalkers
        '
        Me.numNumberOfWalkers.Location = New System.Drawing.Point(12, 67)
        Me.numNumberOfWalkers.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNumberOfWalkers.Name = "numNumberOfWalkers"
        Me.numNumberOfWalkers.Size = New System.Drawing.Size(101, 20)
        Me.numNumberOfWalkers.TabIndex = 2
        Me.numNumberOfWalkers.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number of Steps"
        '
        'numMaximumSteps
        '
        Me.numMaximumSteps.Location = New System.Drawing.Point(123, 67)
        Me.numMaximumSteps.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numMaximumSteps.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMaximumSteps.Name = "numMaximumSteps"
        Me.numMaximumSteps.Size = New System.Drawing.Size(83, 20)
        Me.numMaximumSteps.TabIndex = 3
        Me.numMaximumSteps.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.Location = New System.Drawing.Point(9, 241)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(74, 13)
        Me.lblElapsedTime.TabIndex = 10
        Me.lblElapsedTime.Text = "Elasped Time:"
        '
        'picWalker
        '
        Me.picWalker.Location = New System.Drawing.Point(270, 12)
        Me.picWalker.Name = "picWalker"
        Me.picWalker.Size = New System.Drawing.Size(500, 500)
        Me.picWalker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWalker.TabIndex = 11
        Me.picWalker.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Epsilon Value:"
        '
        'numEpsilonValue
        '
        Me.numEpsilonValue.DecimalPlaces = 3
        Me.numEpsilonValue.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.numEpsilonValue.Location = New System.Drawing.Point(117, 107)
        Me.numEpsilonValue.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numEpsilonValue.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numEpsilonValue.Name = "numEpsilonValue"
        Me.numEpsilonValue.Size = New System.Drawing.Size(58, 20)
        Me.numEpsilonValue.TabIndex = 5
        Me.numEpsilonValue.Value = New Decimal(New Integer() {46, 0, 0, 196608})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Starting Radius:"
        '
        'numStartingRadius
        '
        Me.numStartingRadius.DecimalPlaces = 3
        Me.numStartingRadius.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.numStartingRadius.Location = New System.Drawing.Point(12, 107)
        Me.numStartingRadius.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numStartingRadius.Name = "numStartingRadius"
        Me.numStartingRadius.Size = New System.Drawing.Size(47, 20)
        Me.numStartingRadius.TabIndex = 4
        Me.numStartingRadius.Value = New Decimal(New Integer() {25, 0, 0, 131072})
        '
        'chkSelfAvoidingWalkers
        '
        Me.chkSelfAvoidingWalkers.AutoSize = True
        Me.chkSelfAvoidingWalkers.Location = New System.Drawing.Point(12, 157)
        Me.chkSelfAvoidingWalkers.Name = "chkSelfAvoidingWalkers"
        Me.chkSelfAvoidingWalkers.Size = New System.Drawing.Size(129, 17)
        Me.chkSelfAvoidingWalkers.TabIndex = 7
        Me.chkSelfAvoidingWalkers.Text = "Self-avoiding Walkers"
        Me.chkSelfAvoidingWalkers.UseVisualStyleBackColor = True
        '
        'chkStartinPointOnRadius
        '
        Me.chkStartinPointOnRadius.AutoSize = True
        Me.chkStartinPointOnRadius.Checked = True
        Me.chkStartinPointOnRadius.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStartinPointOnRadius.Location = New System.Drawing.Point(12, 134)
        Me.chkStartinPointOnRadius.Name = "chkStartinPointOnRadius"
        Me.chkStartinPointOnRadius.Size = New System.Drawing.Size(180, 17)
        Me.chkStartinPointOnRadius.TabIndex = 6
        Me.chkStartinPointOnRadius.Text = "Walkers Start on Starting Raidus"
        Me.chkStartinPointOnRadius.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 526)
        Me.Controls.Add(Me.chkStartinPointOnRadius)
        Me.Controls.Add(Me.chkSelfAvoidingWalkers)
        Me.Controls.Add(Me.numStartingRadius)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numEpsilonValue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picWalker)
        Me.Controls.Add(Me.lblElapsedTime)
        Me.Controls.Add(Me.numMaximumSteps)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numNumberOfWalkers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numNumberOfPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numDimensions)
        Me.Controls.Add(Me.btnGeneratePoints)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hubler Dimension Walker Simulator"
        CType(Me.numDimensions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNumberOfPoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNumberOfWalkers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaximumSteps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWalker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEpsilonValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStartingRadius, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGeneratePoints As System.Windows.Forms.Button
    Friend WithEvents numDimensions As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numNumberOfPoints As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numNumberOfWalkers As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numMaximumSteps As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblElapsedTime As System.Windows.Forms.Label
    Friend WithEvents picWalker As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numEpsilonValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numStartingRadius As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkSelfAvoidingWalkers As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartinPointOnRadius As System.Windows.Forms.CheckBox

End Class
