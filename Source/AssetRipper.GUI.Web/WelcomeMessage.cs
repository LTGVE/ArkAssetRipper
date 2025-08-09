namespace AssetRipper.GUI.Web;

public static class WelcomeMessage
{
	private const string AsciiArt = """
		    _         _        _                 _   ____  _                       
		   / \   _ __| | __   / \   ___ ___  ___| |_|  _ \(_)_ __  _ __   ___ _ __ 
		  / _ \ | '__| |/ /  / _ \ / __/ __|/ _ \ __| |_) | | '_ \| '_ \ / _ \ '__|
		 / ___ \| |  |   <  / ___ \\__ \__ \  __/ |_|  _ <| | |_) | |_) |  __/ |   
		/_/   \_\_|  |_|\_\/_/   \_\___/___/\___|\__|_| \_\_| .__/| .__/ \___|_|   
		                                                    |_|   |_|              
		""";

	private const string Directions = """
		一会后,会出现"Now listening on:",点击URL
		打开后就会看见ArkAssetRipper的欢迎界面,点击"Language"切换语言,点击"文件"-"加载文件"即可加载.
		""";

	public static void Print()
	{
		Console.WriteLine(AsciiArt);
		Console.WriteLine();
		Console.WriteLine(Directions);
		Console.WriteLine();
	}
}
