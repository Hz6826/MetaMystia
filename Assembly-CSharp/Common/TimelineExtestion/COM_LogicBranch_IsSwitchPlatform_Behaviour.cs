using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000447 RID: 1095
	public class COM_LogicBranch_IsSwitchPlatform_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600797B RID: 31099 RVA: 0x002317A4 File Offset: 0x0022F9A4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_IsSwitchPlatform_Behaviour()
		{
			Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_LogicBranch_IsSwitchPlatform_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform_Behaviour>.NativeClassPtr);
			COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeFieldInfoPtr_trueAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform_Behaviour>.NativeClassPtr, "trueAddFrames");
			COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeFieldInfoPtr_falseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform_Behaviour>.NativeClassPtr, "falseAddFrames");
			COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform_Behaviour>.NativeClassPtr, 100687735);
			COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform_Behaviour>.NativeClassPtr, 100687736);
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x00231824 File Offset: 0x0022FA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294098, XrefRangeEnd = 294104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x00231860 File Offset: 0x0022FA60
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_IsSwitchPlatform_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_IsSwitchPlatform_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x00041A09 File Offset: 0x0003FC09
		public COM_LogicBranch_IsSwitchPlatform_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x0023189C File Offset: 0x0022FA9C
		// (set) Token: 0x06007980 RID: 31104 RVA: 0x00041A12 File Offset: 0x0003FC12
		public unsafe int trueAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeFieldInfoPtr_trueAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeFieldInfoPtr_trueAddFrames)) = value;
			}
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x06007981 RID: 31105 RVA: 0x002318C4 File Offset: 0x0022FAC4
		// (set) Token: 0x06007982 RID: 31106 RVA: 0x00041A2D File Offset: 0x0003FC2D
		public unsafe int falseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeFieldInfoPtr_falseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_IsSwitchPlatform_Behaviour.NativeFieldInfoPtr_falseAddFrames)) = value;
			}
		}

		// Token: 0x04004FF4 RID: 20468
		private static readonly IntPtr NativeFieldInfoPtr_trueAddFrames;

		// Token: 0x04004FF5 RID: 20469
		private static readonly IntPtr NativeFieldInfoPtr_falseAddFrames;

		// Token: 0x04004FF6 RID: 20470
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FF7 RID: 20471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
