using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTK_Test
{
    class GLTest : GLControl
    {
        public GLTest()
            : base(GraphicsMode.Default, 2, 0, GraphicsContextFlags.Default)
        {
            Application.Idle += (o, e) => Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(1, 0, 0, 1);

            SwapBuffers();
        }
    }
}
