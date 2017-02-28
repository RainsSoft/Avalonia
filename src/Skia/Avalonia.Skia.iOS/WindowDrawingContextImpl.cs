
namespace Avalonia.Skia
{
#if !DESKTOP
    // not sure we need this yet
    internal class WindowDrawingContextImpl : DrawingContextImpl
    {
        WindowRenderTarget _target;

        public WindowDrawingContextImpl(WindowRenderTarget target)
            : base(target.Surface.Canvas, null)
        {
            _target = target;
        }

        public override void Dispose()
        {
            base.Dispose();
            _target.Present();
        }
    }
#endif
}