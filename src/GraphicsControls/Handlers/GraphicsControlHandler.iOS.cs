using Microsoft.Maui.Graphics.Native;
using Microsoft.Maui.Handlers;

namespace Microsoft.Maui.Graphics.Controls
{
	public partial class GraphicsControlHandler<TViewDrawable, TVirtualView> : ViewHandler<TVirtualView, NativeGraphicsView>
	{
		protected override NativeGraphicsView CreateNativeView() =>
			new NativeGraphicsControlView { GraphicsControl = this };

		public void Invalidate() =>
			NativeView?.InvalidateDrawable();
	}
}