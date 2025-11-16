using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000428 RID: 1064
	public class COM_LogicBranch_OnlyForSkipTutorial_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x0600788C RID: 30860 RVA: 0x0022EFA8 File Offset: 0x0022D1A8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_OnlyForSkipTutorial_Behaviour()
		{
			Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_LogicBranch_OnlyForSkipTutorial_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial_Behaviour>.NativeClassPtr);
			COM_LogicBranch_OnlyForSkipTutorial_Behaviour.NativeFieldInfoPtr_skipSkipTutorialFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial_Behaviour>.NativeClassPtr, "skipSkipTutorialFrames");
			COM_LogicBranch_OnlyForSkipTutorial_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial_Behaviour>.NativeClassPtr, 100687652);
			COM_LogicBranch_OnlyForSkipTutorial_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial_Behaviour>.NativeClassPtr, 100687653);
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x0022F014 File Offset: 0x0022D214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293636, XrefRangeEnd = 293663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_OnlyForSkipTutorial_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x0022F050 File Offset: 0x0022D250
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_OnlyForSkipTutorial_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_OnlyForSkipTutorial_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00041325 File Offset: 0x0003F525
		public COM_LogicBranch_OnlyForSkipTutorial_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x06007890 RID: 30864 RVA: 0x0022F08C File Offset: 0x0022D28C
		// (set) Token: 0x06007891 RID: 30865 RVA: 0x0004132E File Offset: 0x0003F52E
		public unsafe int skipSkipTutorialFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_OnlyForSkipTutorial_Behaviour.NativeFieldInfoPtr_skipSkipTutorialFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_OnlyForSkipTutorial_Behaviour.NativeFieldInfoPtr_skipSkipTutorialFrames)) = value;
			}
		}

		// Token: 0x04004F79 RID: 20345
		private static readonly IntPtr NativeFieldInfoPtr_skipSkipTutorialFrames;

		// Token: 0x04004F7A RID: 20346
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F7B RID: 20347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
