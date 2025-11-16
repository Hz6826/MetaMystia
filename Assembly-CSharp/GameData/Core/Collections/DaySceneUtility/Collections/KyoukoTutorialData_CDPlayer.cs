using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B0 RID: 688
	[Serializable]
	public class KyoukoTutorialData_CDPlayer : KyoukoTutorialData
	{
		// Token: 0x06005650 RID: 22096 RVA: 0x001C1570 File Offset: 0x001BF770
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_CDPlayer()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_CDPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_CDPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_CDPlayer>.NativeClassPtr);
			KyoukoTutorialData_CDPlayer.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_CDPlayer>.NativeClassPtr, 100680865);
			KyoukoTutorialData_CDPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_CDPlayer>.NativeClassPtr, 100680866);
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x06005651 RID: 22097 RVA: 0x001C15C8 File Offset: 0x001BF7C8
		public unsafe override bool NeedToShow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214360, XrefRangeEnd = 214361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_CDPlayer.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x001C1610 File Offset: 0x001BF810
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_CDPlayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_CDPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_CDPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x0002E76E File Offset: 0x0002C96E
		public KyoukoTutorialData_CDPlayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040039DB RID: 14811
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0;

		// Token: 0x040039DC RID: 14812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
