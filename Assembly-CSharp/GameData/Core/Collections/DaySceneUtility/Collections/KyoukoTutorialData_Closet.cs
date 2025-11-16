using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002AF RID: 687
	[Serializable]
	public class KyoukoTutorialData_Closet : KyoukoTutorialData
	{
		// Token: 0x0600564C RID: 22092 RVA: 0x001C1494 File Offset: 0x001BF694
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_Closet()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_Closet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_Closet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_Closet>.NativeClassPtr);
			KyoukoTutorialData_Closet.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_Closet>.NativeClassPtr, 100680863);
			KyoukoTutorialData_Closet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_Closet>.NativeClassPtr, 100680864);
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x0600564D RID: 22093 RVA: 0x001C14EC File Offset: 0x001BF6EC
		public unsafe override bool NeedToShow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214359, XrefRangeEnd = 214360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_Closet.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x001C1534 File Offset: 0x001BF734
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_Closet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_Closet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_Closet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x0002E765 File Offset: 0x0002C965
		public KyoukoTutorialData_Closet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040039D9 RID: 14809
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0;

		// Token: 0x040039DA RID: 14810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
