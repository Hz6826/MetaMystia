using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000414 RID: 1044
	public class NormalPlayableBehaviour : PlayableBehaviour
	{
		// Token: 0x060077C8 RID: 30664 RVA: 0x0022D04C File Offset: 0x0022B24C
		// Note: this type is marked as 'beforefieldinit'.
		static NormalPlayableBehaviour()
		{
			Il2CppClassPointerStore<NormalPlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "NormalPlayableBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalPlayableBehaviour>.NativeClassPtr);
			NormalPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Final_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalPlayableBehaviour>.NativeClassPtr, 100687597);
			NormalPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalPlayableBehaviour>.NativeClassPtr, 100687598);
			NormalPlayableBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalPlayableBehaviour>.NativeClassPtr, 100687599);
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x0022D0B8 File Offset: 0x0022B2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293409, XrefRangeEnd = 293415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Final_Void_Playable_FrameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x0022D104 File Offset: 0x0022B304
		[CallerCount(0)]
		public unsafe virtual void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NormalPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x0022D140 File Offset: 0x0022B340
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalPlayableBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalPlayableBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalPlayableBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x00040C48 File Offset: 0x0003EE48
		public NormalPlayableBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004F14 RID: 20244
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Final_Void_Playable_FrameData_0;

		// Token: 0x04004F15 RID: 20245
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04004F16 RID: 20246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
