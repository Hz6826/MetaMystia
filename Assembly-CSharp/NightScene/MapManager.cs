using System;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using NightScene.Tiles;

namespace NightScene
{
	// Token: 0x0200019E RID: 414
	public class MapManager : MonoSingleton<IzakayaMap>
	{
		// Token: 0x06002CEF RID: 11503 RVA: 0x001338B0 File Offset: 0x00131AB0
		// Note: this type is marked as 'beforefieldinit'.
		static MapManager()
		{
			Il2CppClassPointerStore<MapManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene", "MapManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapManager>.NativeClassPtr);
			MapManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_IzakayaMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapManager>.NativeClassPtr, 100671153);
			MapManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapManager>.NativeClassPtr, 100671154);
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x00133908 File Offset: 0x00131B08
		public new unsafe static IzakayaMap Instance
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 100731, RefRangeEnd = 100746, XrefRangeStart = 100706, XrefRangeEnd = 100731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_IzakayaMap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IzakayaMap>(intPtr3) : null;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0013393C File Offset: 0x00131B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100746, XrefRangeEnd = 100749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x0001A182 File Offset: 0x00018382
		public MapManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_IzakayaMap_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
