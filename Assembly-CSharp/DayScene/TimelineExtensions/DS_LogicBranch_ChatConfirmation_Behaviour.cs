using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000144 RID: 324
	public class DS_LogicBranch_ChatConfirmation_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002667 RID: 9831 RVA: 0x0011F30C File Offset: 0x0011D50C
		// Note: this type is marked as 'beforefieldinit'.
		static DS_LogicBranch_ChatConfirmation_Behaviour()
		{
			Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_LogicBranch_ChatConfirmation_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr);
			DS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, "acceptAddFrames");
			DS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, "refuseAddFrames");
			DS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, 100670190);
			DS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, 100670191);
			DS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__2_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr, 100670192);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x0011F3A0 File Offset: 0x0011D5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90218, XrefRangeEnd = 90229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x0011F3DC File Offset: 0x0011D5DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_LogicBranch_ChatConfirmation_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x0011F418 File Offset: 0x0011D618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90229, XrefRangeEnd = 90236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBehaviourEnter_b__2_0(bool isAccept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isAccept;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_LogicBranch_ChatConfirmation_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__2_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00016A74 File Offset: 0x00014C74
		public DS_LogicBranch_ChatConfirmation_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0011F458 File Offset: 0x0011D658
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x00016A7D File Offset: 0x00014C7D
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x0011F480 File Offset: 0x0011D680
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x00016A98 File Offset: 0x00014C98
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation_Behaviour.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__2_0_Private_Void_Boolean_0;
	}
}
