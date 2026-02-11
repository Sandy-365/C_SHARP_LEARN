using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class Form1 : Form
{
    public Form1()
    {
        this.DoubleBuffered = true;
        this.Width = 1000;
        this.Height = 600;
        this.Text = "Stylish Landscape Art";
        this.BackColor = Color.Black;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        DrawSky(g);
        DrawSun(g);
        DrawGrass(g);
        DrawTree(g);
    }

    void DrawSky(Graphics g)
    {
        Rectangle sky = new Rectangle(0, 0, Width, Height / 2);
        using var brush = new LinearGradientBrush(
            sky, Color.LightSkyBlue, Color.DeepSkyBlue, 90f);
        g.FillRectangle(brush, sky);
    }

    void DrawSun(Graphics g)
    {
        Point center = new Point(780, 120);
        int[] radii = { 80, 60, 40 };
        Color[] colors = {
            Color.FromArgb(60, Color.Yellow),
            Color.Gold,
            Color.Orange
        };

        for (int i = 0; i < radii.Length; i++)
        {
            using var b = new SolidBrush(colors[i]);
            g.FillEllipse(b,
                center.X - radii[i],
                center.Y - radii[i],
                radii[i] * 2,
                radii[i] * 2);
        }
    }

    void DrawGrass(Graphics g)
    {
        using var b = new SolidBrush(Color.SeaGreen);
        g.FillRectangle(b, 0, Height / 2, Width, Height / 2);
    }

    void DrawTree(Graphics g)
    {
        using var trunk = new SolidBrush(Color.SaddleBrown);
        g.FillRectangle(trunk, 430, 280, 40, 160);

        Color[] greens = {
            Color.ForestGreen,
            Color.SeaGreen,
            Color.OliveDrab,
            Color.DarkGreen
        };

        Random r = new Random();

        for (int i = 0; i < 30; i++)
        {
            int size = r.Next(60, 100);
            int x = r.Next(350, 520);
            int y = r.Next(120, 300);

            using var leaf = new SolidBrush(greens[r.Next(greens.Length)]);
            g.FillEllipse(leaf, x, y, size, size);
        }
    }
}
