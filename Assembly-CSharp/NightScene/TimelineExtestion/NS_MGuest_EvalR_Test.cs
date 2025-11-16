using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000200 RID: 512
	public class NS_MGuest_EvalR_Test : PlayableAsset
	{
		// Token: 0x06003D23 RID: 15651 RVA: 0x0016DEB4 File Offset: 0x0016C0B4
		// Note: this type is marked as 'beforefieldinit'.
		static NS_MGuest_EvalR_Test()
		{
			Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_MGuest_EvalR_Test");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr);
			NS_MGuest_EvalR_Test.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr, "ticks");
			NS_MGuest_EvalR_Test.NativeFieldInfoPtr_conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr, "conditions");
			NS_MGuest_EvalR_Test.NativeFieldInfoPtr_oneFailThenFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr, "oneFailThenFailed");
			NS_MGuest_EvalR_Test.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr, 100674554);
			NS_MGuest_EvalR_Test.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr, 100674555);
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x0016DF48 File Offset: 0x0016C148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137100, XrefRangeEnd = 137117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_MGuest_EvalR_Test.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x0016DFB0 File Offset: 0x0016C1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137117, XrefRangeEnd = 137118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_MGuest_EvalR_Test() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_MGuest_EvalR_Test>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_MGuest_EvalR_Test.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x0002234C File Offset: 0x0002054C
		public NS_MGuest_EvalR_Test(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x0016DFEC File Offset: 0x0016C1EC
		// (set) Token: 0x06003D28 RID: 15656 RVA: 0x00022355 File Offset: 0x00020555
		public unsafe int ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x0016E014 File Offset: 0x0016C214
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x00022370 File Offset: 0x00020570
		public unsafe Il2CppStructArray<GuestGroupController.EvaluationResult> conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test.NativeFieldInfoPtr_conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GuestGroupController.EvaluationResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test.NativeFieldInfoPtr_conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x0016E044 File Offset: 0x0016C244
		// (set) Token: 0x06003D2C RID: 15660 RVA: 0x0002238F File Offset: 0x0002058F
		public unsafe bool oneFailThenFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test.NativeFieldInfoPtr_oneFailThenFailed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_MGuest_EvalR_Test.NativeFieldInfoPtr_oneFailThenFailed)) = value;
			}
		}

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeFieldInfoPtr_conditions;

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeFieldInfoPtr_oneFailThenFailed;

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
