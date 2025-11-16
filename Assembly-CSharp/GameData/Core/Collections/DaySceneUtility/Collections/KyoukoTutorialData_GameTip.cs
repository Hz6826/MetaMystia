using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002AC RID: 684
	[Serializable]
	public class KyoukoTutorialData_GameTip : KyoukoTutorialDataMultipleChoice
	{
		// Token: 0x0600562A RID: 22058 RVA: 0x001C0F0C File Offset: 0x001BF10C
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_GameTip()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_GameTip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr);
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_TopMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "TopMode");
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_IzakayaPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "IzakayaPreset");
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutBasement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "AboutBasement");
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutPositiveSpellCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "AboutPositiveSpellCard");
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutKourindou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "AboutKourindou");
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutHakugyokurou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "AboutHakugyokurou");
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "AboutDLC");
			KyoukoTutorialData_GameTip.NativeFieldInfoPtr_ForDLC1MainStory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, "ForDLC1MainStory");
			KyoukoTutorialData_GameTip.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, 100680857);
			KyoukoTutorialData_GameTip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr, 100680858);
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x001C1004 File Offset: 0x001BF204
		public unsafe override Il2CppReferenceArray<KyoukoTutorialData> ChildKyoukoTutorialData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214330, XrefRangeEnd = 214349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_GameTip.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KyoukoTutorialData>>(intPtr3) : null;
			}
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x001C1050 File Offset: 0x001BF250
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_GameTip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_GameTip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_GameTip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x0002E5F5 File Offset: 0x0002C7F5
		public KyoukoTutorialData_GameTip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600562E RID: 22062 RVA: 0x001C108C File Offset: 0x001BF28C
		// (set) Token: 0x0600562F RID: 22063 RVA: 0x0002E5FE File Offset: 0x0002C7FE
		public unsafe KyoukoTutorialDataWithPrefab TopMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_TopMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialDataWithPrefab>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_TopMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06005630 RID: 22064 RVA: 0x001C10BC File Offset: 0x001BF2BC
		// (set) Token: 0x06005631 RID: 22065 RVA: 0x0002E61D File Offset: 0x0002C81D
		public unsafe KyoukoTutorialDataWithPrefab IzakayaPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_IzakayaPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialDataWithPrefab>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_IzakayaPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06005632 RID: 22066 RVA: 0x001C10EC File Offset: 0x001BF2EC
		// (set) Token: 0x06005633 RID: 22067 RVA: 0x0002E63C File Offset: 0x0002C83C
		public unsafe KyoukoTutorialData_Basement AboutBasement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutBasement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_Basement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutBasement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06005634 RID: 22068 RVA: 0x001C111C File Offset: 0x001BF31C
		// (set) Token: 0x06005635 RID: 22069 RVA: 0x0002E65B File Offset: 0x0002C85B
		public unsafe KyoukoTutorialData_SpellCard AboutPositiveSpellCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutPositiveSpellCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_SpellCard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutPositiveSpellCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06005636 RID: 22070 RVA: 0x001C114C File Offset: 0x001BF34C
		// (set) Token: 0x06005637 RID: 22071 RVA: 0x0002E67A File Offset: 0x0002C87A
		public unsafe KyoukoTutorialData AboutKourindou
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutKourindou);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutKourindou), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06005638 RID: 22072 RVA: 0x001C117C File Offset: 0x001BF37C
		// (set) Token: 0x06005639 RID: 22073 RVA: 0x0002E699 File Offset: 0x0002C899
		public unsafe KyoukoTutorialData AboutHakugyokurou
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutHakugyokurou);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutHakugyokurou), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x001C11AC File Offset: 0x001BF3AC
		// (set) Token: 0x0600563B RID: 22075 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		public unsafe KyoukoTutorialData AboutDLC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutDLC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_AboutDLC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x0600563C RID: 22076 RVA: 0x001C11DC File Offset: 0x001BF3DC
		// (set) Token: 0x0600563D RID: 22077 RVA: 0x0002E6D7 File Offset: 0x0002C8D7
		public unsafe KyoukoTutorialData_DLC1MainStory ForDLC1MainStory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_ForDLC1MainStory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_DLC1MainStory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_GameTip.NativeFieldInfoPtr_ForDLC1MainStory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039C8 RID: 14792
		private static readonly IntPtr NativeFieldInfoPtr_TopMode;

		// Token: 0x040039C9 RID: 14793
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaPreset;

		// Token: 0x040039CA RID: 14794
		private static readonly IntPtr NativeFieldInfoPtr_AboutBasement;

		// Token: 0x040039CB RID: 14795
		private static readonly IntPtr NativeFieldInfoPtr_AboutPositiveSpellCard;

		// Token: 0x040039CC RID: 14796
		private static readonly IntPtr NativeFieldInfoPtr_AboutKourindou;

		// Token: 0x040039CD RID: 14797
		private static readonly IntPtr NativeFieldInfoPtr_AboutHakugyokurou;

		// Token: 0x040039CE RID: 14798
		private static readonly IntPtr NativeFieldInfoPtr_AboutDLC;

		// Token: 0x040039CF RID: 14799
		private static readonly IntPtr NativeFieldInfoPtr_ForDLC1MainStory;

		// Token: 0x040039D0 RID: 14800
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Virtual_get_Il2CppReferenceArray_1_KyoukoTutorialData_0;

		// Token: 0x040039D1 RID: 14801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
