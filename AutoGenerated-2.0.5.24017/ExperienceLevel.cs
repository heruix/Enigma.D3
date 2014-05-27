public class ExperienceLevel : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1D0; // 464

	public ExperienceLevel(ProcessMemory memory, int address)
		: base(memory, address) { }

	public long x000 { get { return Field<long>(0x000); } }
	public int x008 { get { return Field<int>(0x008); } }
	public int x00C { get { return Field<int>(0x00C); } }
	public float x010 { get { return Field<float>(0x010); } }
	public float x014 { get { return Field<float>(0x014); } }
	public int x018 { get { return Field<int>(0x018); } }
	public int x01C { get { return Field<int>(0x01C); } }
	public int x020 { get { return Field<int>(0x020); } }
	public int x024 { get { return Field<int>(0x024); } }
	public int x028 { get { return Field<int>(0x028); } }
	public int x02C { get { return Field<int>(0x02C); } }
	public int x030 { get { return Field<int>(0x030); } }
	public int x034 { get { return Field<int>(0x034); } }
	public int x038 { get { return Field<int>(0x038); } }
	public int x03C { get { return Field<int>(0x03C); } }
	public int x040 { get { return Field<int>(0x040); } }
	public int x044 { get { return Field<int>(0x044); } }
	public int x048 { get { return Field<int>(0x048); } }
	public int x04C { get { return Field<int>(0x04C); } }
	public int x050 { get { return Field<int>(0x050); } }
	public int x054 { get { return Field<int>(0x054); } }
	public int x058 { get { return Field<int>(0x058); } }
	public int x05C { get { return Field<int>(0x05C); } }
	public int x060 { get { return Field<int>(0x060); } }
	public int x064 { get { return Field<int>(0x064); } }
	public int x068 { get { return Field<int>(0x068); } }
	public int x06C { get { return Field<int>(0x06C); } }
	public int x070 { get { return Field<int>(0x070); } }
	public int x074 { get { return Field<int>(0x074); } }
	public int x078 { get { return Field<int>(0x078); } }
	public int x07C { get { return Field<int>(0x07C); } }
	public int x080 { get { return Field<int>(0x080); } }
	public int x084 { get { return Field<int>(0x084); } }
	public int x088 { get { return Field<int>(0x088); } }
	public int x08C { get { return Field<int>(0x08C); } }
	public int x090 { get { return Field<int>(0x090); } }
	public int x094 { get { return Field<int>(0x094); } }
	public int x098 { get { return Field<int>(0x098); } }
	public int x09C { get { return Field<int>(0x09C); } }
	public int x0A0 { get { return Field<int>(0x0A0); } }
	public float x0A4 { get { return Field<float>(0x0A4); } }
	public float x0A8 { get { return Field<float>(0x0A8); } }
	public float x0AC { get { return Field<float>(0x0AC); } }
	public int x0B0 { get { return Field<int>(0x0B0); } }
	public int x0B4 { get { return Field<int>(0x0B4); } }
	public int x0B8 { get { return Field<int>(0x0B8); } }
	public int x0BC { get { return Field<int>(0x0BC); } }
	public int x0C0 { get { return Field<int>(0x0C0); } }
	public int x0C4 { get { return Field<int>(0x0C4); } }
	public int x0C8 { get { return Field<int>(0x0C8); } }
	public int x0CC { get { return Field<int>(0x0CC); } }
	public int x0D0 { get { return Field<int>(0x0D0); } }
	public int x0D4 { get { return Field<int>(0x0D4); } }
	public int x0D8 { get { return Field<int>(0x0D8); } }
	public int x0DC { get { return Field<int>(0x0DC); } }
	public int x0E0 { get { return Field<int>(0x0E0); } }
	public int x0E4 { get { return Field<int>(0x0E4); } }
	public int x0E8 { get { return Field<int>(0x0E8); } }
	public int x0EC { get { return Field<int>(0x0EC); } }
	public int x0F0 { get { return Field<int>(0x0F0); } }
	public int x0F4 { get { return Field<int>(0x0F4); } }
	public int x0F8 { get { return Field<int>(0x0F8); } }
	public int x0FC { get { return Field<int>(0x0FC); } }
	public int x100 { get { return Field<int>(0x100); } }
	public int x104 { get { return Field<int>(0x104); } }
	public int x108 { get { return Field<int>(0x108); } }
	public int x10C { get { return Field<int>(0x10C); } }
	public int x120 { get { return Field<int>(0x120); } }
	public int x124 { get { return Field<int>(0x124); } }
	public int x128 { get { return Field<int>(0x128); } }
	public int x12C { get { return Field<int>(0x12C); } }
	public int x130 { get { return Field<int>(0x130); } }
	public int x134 { get { return Field<int>(0x134); } }
	public int x138 { get { return Field<int>(0x138); } }
	public int x13C { get { return Field<int>(0x13C); } }
	public int x140 { get { return Field<int>(0x140); } }
	public int x144 { get { return Field<int>(0x144); } }
	public int x148 { get { return Field<int>(0x148); } }
	public int x14C { get { return Field<int>(0x14C); } }
	public float x154 { get { return Field<float>(0x154); } }
	public float x158 { get { return Field<float>(0x158); } }
	public float x15C { get { return Field<float>(0x15C); } }
	public long x160 { get { return Field<long>(0x160); } }
	public int x168 { get { return Field<int>(0x168); } }
	public int x16C { get { return Field<int>(0x16C); } }
	public int x170 { get { return Field<int>(0x170); } }
	public int x174 { get { return Field<int>(0x174); } }
	public int x178 { get { return Field<int>(0x178); } }
	public int x17C { get { return Field<int>(0x17C); } }
	public int x180 { get { return Field<int>(0x180); } }
	public int x184 { get { return Field<int>(0x184); } }
	public int x188 { get { return Field<int>(0x188); } }
	public int x18C { get { return Field<int>(0x18C); } }
	public int x190 { get { return Field<int>(0x190); } }
	public int x194 { get { return Field<int>(0x194); } }
	public int x198 { get { return Field<int>(0x198); } }
	public int x19C { get { return Field<int>(0x19C); } }
	public int x1A0 { get { return Field<int>(0x1A0); } }
	public int x1A4 { get { return Field<int>(0x1A4); } }
	public int x1A8 { get { return Field<int>(0x1A8); } }
	public int x1AC { get { return Field<int>(0x1AC); } }
	public float x1B0 { get { return Field<float>(0x1B0); } }
	public int x1B4 { get { return Field<int>(0x1B4); } }
	public int x1B8 { get { return Field<int>(0x1B8); } }
	public int x1BC { get { return Field<int>(0x1BC); } }
	public int x1C0 { get { return Field<int>(0x1C0); } }
	public int x1C4 { get { return Field<int>(0x1C4); } }
	public int x1C8 { get { return Field<int>(0x1C8); } }
}