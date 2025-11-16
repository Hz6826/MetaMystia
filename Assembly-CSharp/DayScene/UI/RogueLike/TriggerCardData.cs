using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	[StructLayout(2)]
	public struct TriggerCardData
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x000FE31C File Offset: 0x000FC51C
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerCardData()
		{
			Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "TriggerCardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr);
			TriggerCardData.NativeFieldInfoPtr_m_TriggerCardCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr, "m_TriggerCardCondition");
			TriggerCardData.NativeFieldInfoPtr_m_InitialCardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr, "m_InitialCardNum");
			TriggerCardData.NativeFieldInfoPtr_m_AddMaxCardNumWhenTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr, "m_AddMaxCardNumWhenTrigger");
			TriggerCardData.NativeMethodInfoPtr_get_TriggerCardCondition_Public_get_TriggerCardCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr, 100668461);
			TriggerCardData.NativeMethodInfoPtr_get_InitialCardNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr, 100668462);
			TriggerCardData.NativeMethodInfoPtr_get_AddMaxCardNumWhenTrigger_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr, 100668463);
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x000FE3C4 File Offset: 0x000FC5C4
		public unsafe TriggerCardCondition TriggerCardCondition
		{
			[CallerCount(140)]
			[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerCardData.NativeMethodInfoPtr_get_TriggerCardCondition_Public_get_TriggerCardCondition_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000FE3F4 File Offset: 0x000FC5F4
		public unsafe int InitialCardNum
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerCardData.NativeMethodInfoPtr_get_InitialCardNum_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x000FE424 File Offset: 0x000FC624
		public unsafe bool AddMaxCardNumWhenTrigger
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerCardData.NativeMethodInfoPtr_get_AddMaxCardNumWhenTrigger_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00011711 File Offset: 0x0000F911
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerCardData>.NativeClassPtr, ref this));
		}

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerCardCondition;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialCardNum;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_m_AddMaxCardNumWhenTrigger;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggerCardCondition_Public_get_TriggerCardCondition_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialCardNum_Public_get_Int32_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_get_AddMaxCardNumWhenTrigger_Public_get_Boolean_0;

		// Token: 0x04001310 RID: 4880
		[FieldOffset(0)]
		public TriggerCardCondition m_TriggerCardCondition;

		// Token: 0x04001311 RID: 4881
		[FieldOffset(4)]
		public int m_InitialCardNum;

		// Token: 0x04001312 RID: 4882
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_AddMaxCardNumWhenTrigger;
	}
}
