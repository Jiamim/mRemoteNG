﻿using System.ComponentModel;
using System.Windows.Forms;
using mRemoteNG.Connection;
using mRemoteNG.Tools;

namespace mRemoteNG.UI.Controls
{
	public class MultiSshToolStrip : ToolStrip
	{
		private IContainer components;
		private ToolStripLabel _lblMultiSsh;
		private ToolStripTextBox _txtMultiSsh;
		private MultiSSHController _multiSshController;

	    public MultiSshToolStrip() : this(null)
	    {
	    }

		public MultiSshToolStrip(IConnectionsService connectionsService)
		{
			InitializeComponent();
			_multiSshController = new MultiSSHController(_txtMultiSsh, connectionsService);
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			_lblMultiSsh = new ToolStripLabel();
			_txtMultiSsh = new ToolStripTextBox();
			SuspendLayout();
			// 
			// lblMultiSSH
			// 
			_lblMultiSsh.Name = "_lblMultiSsh";
			_lblMultiSsh.Size = new System.Drawing.Size(77, 22);
			_lblMultiSsh.Text = "Multi SSH:";
			// 
			// txtMultiSSH
			// 
			_txtMultiSsh.Name = "_txtMultiSsh";
			_txtMultiSsh.Size = new System.Drawing.Size(300, 25);
			_txtMultiSsh.ToolTipText = "Press ENTER to send. Ctrl+C is sent immediately.";

			Items.AddRange(new ToolStripItem[] {
				_lblMultiSsh,
				_txtMultiSsh});
			ResumeLayout(true);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				components?.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
