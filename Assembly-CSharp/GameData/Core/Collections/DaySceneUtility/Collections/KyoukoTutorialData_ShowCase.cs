using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002AE RID: 686
	[Serializable]
	public class KyoukoTutorialData_ShowCase : KyoukoTutorialData
	{
		// Token: 0x06005648 RID: 22088 RVA: 0x001C13B8 File Offset: 0x001BF5B8
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_ShowCase()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_ShowCase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_ShowCase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_ShowCase>.NativeClassPtr);
			KyoukoTutorialData_ShowCase.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_ShowCase>.NativeClassPtr, 100680861);
			KyoukoTutorialData_ShowCase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_ShowCase>.NativeClassPtr, 100680862);
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06005649 RID: 22089 RVA: 0x001C1410 File Offset: 0x001BF610
		public unsafe override bool NeedToShow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214358, XrefRangeEnd = 214359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_ShowCase.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x001C1458 File Offset: 0x001BF658
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_ShowCase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_ShowCase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_ShowCase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x0002E75C File Offset: 0x0002C95C
		public KyoukoTutorialData_ShowCase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040039D7 RID: 14807
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0;

		// Token: 0x040039D8 RID: 14808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
