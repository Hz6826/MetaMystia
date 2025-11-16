using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E7 RID: 487
	public class NS_LogicBranch_ChatConfirmation_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003C81 RID: 15489 RVA: 0x0016C190 File Offset: 0x0016A390
		// Note: this type is marked as 'beforefieldinit'.
		static NS_LogicBranch_ChatConfirmation_Behaviour()
		{
			Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_LogicBranch_ChatConfirmation_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr);
			NS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, "acceptAddFrames");
			NS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, "refuseAddFrames");
			NS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, 100674499);
			NS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, 100674500);
			NS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__2_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, 100674501);
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x0016C224 File Offset: 0x0016A424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136860, XrefRangeEnd = 136871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x0016C260 File Offset: 0x0016A460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_LogicBranch_ChatConfirmation_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x0016C29C File Offset: 0x0016A49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136871, XrefRangeEnd = 136878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBehaviourEnter_b__2_0(bool isAccept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isAccept;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__2_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00021F1E File Offset: 0x0002011E
		public NS_LogicBranch_ChatConfirmation_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x0016C2DC File Offset: 0x0016A4DC
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x00021F27 File Offset: 0x00020127
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06003C88 RID: 15496 RVA: 0x0016C304 File Offset: 0x0016A504
		// (set) Token: 0x06003C89 RID: 15497 RVA: 0x00021F42 File Offset: 0x00020142
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__2_0_Private_Void_Boolean_0;
	}
}
