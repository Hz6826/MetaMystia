using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001FD RID: 509
	public class NS_LogicBranch_ChatConfirmation : PlayableAsset
	{
		// Token: 0x06003D11 RID: 15633 RVA: 0x0016DB04 File Offset: 0x0016BD04
		// Note: this type is marked as 'beforefieldinit'.
		static NS_LogicBranch_ChatConfirmation()
		{
			Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_LogicBranch_ChatConfirmation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation>.NativeClassPtr);
			NS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation>.NativeClassPtr, "acceptAddFrames");
			NS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation>.NativeClassPtr, "refuseAddFrames");
			NS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation>.NativeClassPtr, 100674548);
			NS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation>.NativeClassPtr, 100674549);
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x0016DB84 File Offset: 0x0016BD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137064, XrefRangeEnd = 137078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x0016DBEC File Offset: 0x0016BDEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_LogicBranch_ChatConfirmation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x000222DC File Offset: 0x000204DC
		public NS_LogicBranch_ChatConfirmation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x0016DC28 File Offset: 0x0016BE28
		// (set) Token: 0x06003D16 RID: 15638 RVA: 0x000222E5 File Offset: 0x000204E5
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x0016DC50 File Offset: 0x0016BE50
		// (set) Token: 0x06003D18 RID: 15640 RVA: 0x00022300 File Offset: 0x00020500
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
