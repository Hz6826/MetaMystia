using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E9 RID: 489
	public class NS_MGuest_EvalR_Test_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C90 RID: 15504 RVA: 0x0016C440 File Offset: 0x0016A640
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_EvalR_Test_Behaviour()
		{
			Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_EvalR_Test_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr);
			NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr, "conditions");
			NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_oneFailThenFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr, "oneFailThenFailed");
			NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr, "ticks");
			NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr__Results_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr, "<Results>k__BackingField");
			NS_MGuest_EvalR_Test_Behaviour.NativeMethodInfoPtr_get_Results_Public_Static_get_List_1_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr, 100674506);
			NS_MGuest_EvalR_Test_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr, 100674507);
			NS_MGuest_EvalR_Test_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr, 100674508);
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x0016C4FC File Offset: 0x0016A6FC
		public unsafe static List<GuestGroupController.EvaluationResult> Results
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136915, XrefRangeEnd = 136919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_EvalR_Test_Behaviour.NativeMethodInfoPtr_get_Results_Public_Static_get_List_1_EvaluationResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GuestGroupController.EvaluationResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x0016C530 File Offset: 0x0016A730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136919, XrefRangeEnd = 136934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_EvalR_Test_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x0016C56C File Offset: 0x0016A76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_EvalR_Test_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_EvalR_Test_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_EvalR_Test_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00021F85 File Offset: 0x00020185
		public NS_MGuest_EvalR_Test_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x0016C5A8 File Offset: 0x0016A7A8
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x00021F8E File Offset: 0x0002018E
		public unsafe Il2CppStructArray<GuestGroupController.EvaluationResult> conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GuestGroupController.EvaluationResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x0016C5D8 File Offset: 0x0016A7D8
		// (set) Token: 0x06003C98 RID: 15512 RVA: 0x00021FAD File Offset: 0x000201AD
		public unsafe bool oneFailThenFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_oneFailThenFailed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_oneFailThenFailed)) = value;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x0016C600 File Offset: 0x0016A800
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x00021FC8 File Offset: 0x000201C8
		public unsafe int ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x0016C628 File Offset: 0x0016A828
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x00021FE3 File Offset: 0x000201E3
		public unsafe static List<GuestGroupController.EvaluationResult> _Results_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr__Results_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuestGroupController.EvaluationResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NS_MGuest_EvalR_Test_Behaviour.NativeFieldInfoPtr__Results_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeFieldInfoPtr_conditions;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeFieldInfoPtr_oneFailThenFailed;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeFieldInfoPtr__Results_k__BackingField;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeMethodInfoPtr_get_Results_Public_Static_get_List_1_EvaluationResult_0;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
