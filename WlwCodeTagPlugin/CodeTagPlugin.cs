using System;
using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace WlwCodeTagPlugin
{
	[WriterPlugin("E8529FF2-1CB9-4117-BB3C-56F46F0A2702",
		"<code> HTML tag",
		Description = "Wraps a selection in a <code> tag.",
		HasEditableOptions = false)]
	[InsertableContentSourceAttribute("<code>", SidebarText = "Wrap selection with <code> HTML tag.")]
	public class CodeTagPlugin : ContentSource
	{
		public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
		{
			content = "<code>" + content + "</code>";
			return DialogResult.OK;
		}
	}
}
