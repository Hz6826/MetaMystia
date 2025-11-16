using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001F0 RID: 496
	public class NS_MGuest_PlayEvaluationDialog_Special_Behaviuor : ExtendedPlayableBehaviour
	{
		// Token: 0x06003CCB RID: 15563 RVA: 0x0016CDC4 File Offset: 0x0016AFC4
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_PlayEvaluationDialog_Special_Behaviuor()
		{
			Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_PlayEvaluationDialog_Special_Behaviuor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr);
			NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr, "label");
			NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_evaluationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr, "evaluationResult");
			NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr, "shouldWaitForFinish");
			NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr, 100674522);
			NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr, 100674523);
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x0016CE58 File Offset: 0x0016B058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136973, XrefRangeEnd = 136980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x0016CE94 File Offset: 0x0016B094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_PlayEvaluationDialog_Special_Behaviuor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special_Behaviuor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00022168 File Offset: 0x00020368
		public NS_MGuest_PlayEvaluationDialog_Special_Behaviuor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x0016CED0 File Offset: 0x0016B0D0
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x00022171 File Offset: 0x00020371
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x0016CEF8 File Offset: 0x0016B0F8
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x00022190 File Offset: 0x00020390
		public unsafe GuestGroupController.EvaluationResult evaluationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_evaluationResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_evaluationResult)) = value;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x0016CF20 File Offset: 0x0016B120
		// (set) Token: 0x06003CD4 RID: 15572 RVA: 0x000221AB File Offset: 0x000203AB
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special_Behaviuor.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeFieldInfoPtr_evaluationResult;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
