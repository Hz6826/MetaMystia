using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B2 RID: 690
	[Serializable]
	public class KyoukoTutorialData_DLC1MainStory : KyoukoTutorialData
	{
		// Token: 0x06005658 RID: 22104 RVA: 0x001C1728 File Offset: 0x001BF928
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_DLC1MainStory()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_DLC1MainStory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_DLC1MainStory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_DLC1MainStory>.NativeClassPtr);
			KyoukoTutorialData_DLC1MainStory.NativeFieldInfoPtr_finishEventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_DLC1MainStory>.NativeClassPtr, "finishEventLabel");
			KyoukoTutorialData_DLC1MainStory.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_DLC1MainStory>.NativeClassPtr, 100680872);
			KyoukoTutorialData_DLC1MainStory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_DLC1MainStory>.NativeClassPtr, 100680873);
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06005659 RID: 22105 RVA: 0x001C1794 File Offset: 0x001BF994
		public unsafe override bool NeedToShow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214388, XrefRangeEnd = 214402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_DLC1MainStory.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x001C17DC File Offset: 0x001BF9DC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_DLC1MainStory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_DLC1MainStory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_DLC1MainStory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x0002E780 File Offset: 0x0002C980
		public KyoukoTutorialData_DLC1MainStory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x0600565C RID: 22108 RVA: 0x001C1818 File Offset: 0x001BFA18
		// (set) Token: 0x0600565D RID: 22109 RVA: 0x0002E789 File Offset: 0x0002C989
		public unsafe string finishEventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_DLC1MainStory.NativeFieldInfoPtr_finishEventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_DLC1MainStory.NativeFieldInfoPtr_finishEventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039DF RID: 14815
		private static readonly IntPtr NativeFieldInfoPtr_finishEventLabel;

		// Token: 0x040039E0 RID: 14816
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0;

		// Token: 0x040039E1 RID: 14817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
