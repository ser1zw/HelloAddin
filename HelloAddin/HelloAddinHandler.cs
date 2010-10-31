// HelloAddinHandler.cs
using MonoDevelop.Components.Commands; // CommandHander用
using MonoDevelop.Ide; // IdeApp用

// ネームスペースは MonoDevelop.HelloAddin にする
namespace MonoDevelop.HelloAddin
{
	public class HelloAddinHandler : CommandHandler
	{
		// コマンドを起動したときに実行されるメソッド
		protected override void Run()
		{
			base.Run();
			// ステータスバーに文字列を表示
			IdeApp.Workbench.StatusBar.ShowMessage("Hello, MonoDevelop Addin!!");
		}
		
		// コマンドが表示されたときに実行されるメソッド
		protected override void Update(CommandInfo info)
		{
			base.Update(info);
			info.Enabled = true; // コマンドを有効化
		}
	}
}

