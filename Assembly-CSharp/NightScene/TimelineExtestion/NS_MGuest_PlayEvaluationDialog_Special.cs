using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000207 RID: 519
	public class NS_MGuest_PlayEvaluationDialog_Special : PlayableAsset
	{
		// Token: 0x06003D6B RID: 15723 RVA: 0x0016EAC8 File Offset: 0x0016CCC8
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_PlayEvaluationDialog_Special()
		{
			Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_PlayEvaluationDialog_Special");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr);
			NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr, "label");
			NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_evaluationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr, "evaluationResult");
			NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr, "shouldWaitForFinish");
			NS_MGuest_PlayEvaluationDialog_Special.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr, 100674568);
			NS_MGuest_PlayEvaluationDialog_Special.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr, 100674569);
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x0016EB5C File Offset: 0x0016CD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137224, XrefRangeEnd = 137241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_PlayEvaluationDialog_Special.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x0016EBC4 File Offset: 0x0016CDC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_PlayEvaluationDialog_Special() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_PlayEvaluationDialog_Special>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_PlayEvaluationDialog_Special.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x000225FD File Offset: 0x000207FD
		public NS_MGuest_PlayEvaluationDialog_Special(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06003D6F RID: 15727 RVA: 0x0016EC00 File Offset: 0x0016CE00
		// (set) Token: 0x06003D70 RID: 15728 RVA: 0x00022606 File Offset: 0x00020806
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06003D71 RID: 15729 RVA: 0x0016EC28 File Offset: 0x0016CE28
		// (set) Token: 0x06003D72 RID: 15730 RVA: 0x00022625 File Offset: 0x00020825
		public unsafe GuestGroupController.EvaluationResult evaluationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_evaluationResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_evaluationResult)) = value;
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06003D73 RID: 15731 RVA: 0x0016EC50 File Offset: 0x0016CE50
		// (set) Token: 0x06003D74 RID: 15732 RVA: 0x00022640 File Offset: 0x00020840
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_PlayEvaluationDialog_Special.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeFieldInfoPtr_evaluationResult;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
