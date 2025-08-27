using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetRipper.IO.Files.BundleFiles.BundleTypes;
public class Endfield:LZ4
{
	public new static Endfield Instance => new Endfield();
	protected override (int encCount, int litCount) GetLiteralToken(ReadOnlySpan<byte> cmp, ref int cmpPos)
	{
		var val = cmp[cmpPos++];
		var lit = val & 0b00110011;
		var enc = val & 0b11001100;
		enc >>= 2;
		return ((enc & 0b11) | enc >> 2, (lit & 0b11) | lit >> 2);
	}
	protected override int GetChunkEnd(ReadOnlySpan<byte> cmp, ref int cmpPos) => cmp[cmpPos++] << 8 | cmp[cmpPos++] << 0;
}
