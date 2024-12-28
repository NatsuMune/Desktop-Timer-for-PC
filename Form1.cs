#nullable enable

using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
    private int secondsRemaining;
    private int currentPhase = 0; // 0: Solving, 1: Hints, 2: Solution
    private readonly int[] phaseDurations = { 25 * 60, 5 * 60, 15 * 60 }; // durations in seconds
    private readonly string[] phaseNames = { "Problem Solving", "Check Hints", "Study Solution" };
    
    public Form1()
    {
        InitializeComponent();
        SetupForm();
    }

    private void SetupForm()
    {
        // Enable better DPI scaling
        this.AutoScaleMode = AutoScaleMode.Dpi;
        
        this.Text = "LeetCode 45-Minute Timer";
        this.Size = new Size(450, 400);  // Increased overall size
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.TopMost = true;
        this.BackColor = Color.FromArgb(245, 245, 245);
        this.Padding = new Padding(15);

        // Timer setup - Add these lines back
        timer.Interval = 1000; // 1 second
        timer.Tick += Timer_Tick;

        // Calculate center positions
        int centerX = this.ClientSize.Width / 2;

        // Time display label
        lblTime.Font = new Font("Segoe UI", 48f, FontStyle.Bold);
        lblTime.ForeColor = Color.FromArgb(64, 64, 64);
        lblTime.AutoSize = false;
        lblTime.Size = new Size(400, 100);
        lblTime.TextAlign = ContentAlignment.MiddleCenter;
        lblTime.Location = new Point((ClientSize.Width - lblTime.Width) / 2, 20);

        // Phase label
        lblPhase.Font = new Font("Segoe UI", 14f);
        lblPhase.ForeColor = Color.FromArgb(100, 100, 100);
        lblPhase.AutoSize = false;
        lblPhase.Size = new Size(400, 40);
        lblPhase.TextAlign = ContentAlignment.MiddleCenter;
        lblPhase.Location = new Point((ClientSize.Width - lblPhase.Width) / 2, 130);

        // Common button styling
        Action<Button> styleButton = (btn) => {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.Font = new Font("Segoe UI", 10f);
            btn.Size = new Size(120, 40);  // Slightly wider buttons
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(64, 64, 64);
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
        };

        // Start button
        styleButton(btnStart);
        btnStart.Text = "Start";
        btnStart.Location = new Point(centerX - 130, 190);
        btnStart.Click += BtnStart_Click;

        // Reset button
        styleButton(btnReset);
        btnReset.Text = "Reset";
        btnReset.Location = new Point(centerX + 10, 190);
        btnReset.Click += BtnReset_Click;

        // Skip button
        styleButton(btnSkip);
        btnSkip.Text = "Skip Phase";
        btnSkip.Location = new Point(centerX - 60, 250);
        btnSkip.Click += BtnSkip_Click;

        ResetTimer();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        secondsRemaining--;
        UpdateDisplay();

        if (secondsRemaining <= 0)
        {
            if (currentPhase < 2)
            {
                PlayAlert();
                currentPhase++;
                secondsRemaining = phaseDurations[currentPhase];
                UpdateDisplay();
            }
            else
            {
                timer.Stop();
                PlayAlert();
                MessageBox.Show("Time's up! Session completed.", "Session End", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTimer();
            }
        }
    }

    private void UpdateDisplay()
    {
        int minutes = secondsRemaining / 60;
        int seconds = secondsRemaining % 60;
        lblTime.Text = $"{minutes:D2}:{seconds:D2}";
        lblPhase.Text = phaseNames[currentPhase];
    }

    private void BtnStart_Click(object? sender, EventArgs e)
    {
        if (timer.Enabled)
        {
            timer.Stop();
            btnStart.Text = "Start";
        }
        else
        {
            timer.Start();
            btnStart.Text = "Pause";
        }
    }

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        ResetTimer();
    }

    private void ResetTimer()
    {
        timer.Stop();
        currentPhase = 0;
        secondsRemaining = phaseDurations[currentPhase];
        btnStart.Text = "Start";
        UpdateDisplay();
    }

    private void PlayAlert()
    {
        SystemSounds.Exclamation.Play();
    }

    private void BtnSkip_Click(object? sender, EventArgs e)
    {
        if (currentPhase < 2)
        {
            PlayAlert();
            currentPhase++;
            secondsRemaining = phaseDurations[currentPhase];
            UpdateDisplay();
        }
        else
        {
            timer.Stop();
            PlayAlert();
            MessageBox.Show("Time's up! Session completed.", "Session End", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetTimer();
        }
    }
} 