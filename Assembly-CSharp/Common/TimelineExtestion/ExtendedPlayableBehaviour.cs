using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000413 RID: 1043
	public class ExtendedPlayableBehaviour : PlayableBehaviour
	{
		// Token: 0x060077C2 RID: 30658 RVA: 0x0022CED4 File Offset: 0x0022B0D4
		// Note: this type is marked as 'beforefieldinit'.
		static ExtendedPlayableBehaviour()
		{
			Il2CppClassPointerStore<ExtendedPlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "ExtendedPlayableBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedPlayableBehaviour>.NativeClassPtr);
			ExtendedPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Final_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPlayableBehaviour>.NativeClassPtr, 100687593);
			ExtendedPlayableBehaviour.NativeMethodInfoPtr_Continue_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPlayableBehaviour>.NativeClassPtr, 100687594);
			ExtendedPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPlayableBehaviour>.NativeClassPtr, 100687595);
			ExtendedPlayableBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedPlayableBehaviour>.NativeClassPtr, 100687596);
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x0022CF54 File Offset: 0x0022B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293367, XrefRangeEnd = 293377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Final_Void_Playable_FrameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x0022CFA0 File Offset: 0x0022B1A0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 293386, RefRangeEnd = 293409, XrefRangeStart = 293377, XrefRangeEnd = 293386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPlayableBehaviour.NativeMethodInfoPtr_Continue_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x0022CFD4 File Offset: 0x0022B1D4
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x0022D010 File Offset: 0x0022B210
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtendedPlayableBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedPlayableBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedPlayableBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00040C3F File Offset: 0x0003EE3F
		public ExtendedPlayableBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004F10 RID: 20240
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Final_Void_Playable_FrameData_0;

		// Token: 0x04004F11 RID: 20241
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Protected_Void_0;

		// Token: 0x04004F12 RID: 20242
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04004F13 RID: 20243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
