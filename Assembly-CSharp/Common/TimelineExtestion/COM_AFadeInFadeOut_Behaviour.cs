using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000433 RID: 1075
	public class COM_AFadeInFadeOut_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078F6 RID: 30966 RVA: 0x0022FFE4 File Offset: 0x0022E1E4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_AFadeInFadeOut_Behaviour()
		{
			Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_AFadeInFadeOut_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr);
			COM_AFadeInFadeOut_Behaviour.NativeFieldInfoPtr_notWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr, "notWait");
			COM_AFadeInFadeOut_Behaviour.NativeFieldInfoPtr_transitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr, "transitionType");
			COM_AFadeInFadeOut_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr, 100687677);
			COM_AFadeInFadeOut_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr, 100687678);
			COM_AFadeInFadeOut_Behaviour.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr, 100687679);
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x00230078 File Offset: 0x0022E278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293768, XrefRangeEnd = 293788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_AFadeInFadeOut_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x002300B4 File Offset: 0x0022E2B4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_AFadeInFadeOut_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_AFadeInFadeOut_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_AFadeInFadeOut_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x002300F0 File Offset: 0x0022E2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293788, XrefRangeEnd = 293791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_AFadeInFadeOut_Behaviour.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x000416FD File Offset: 0x0003F8FD
		public COM_AFadeInFadeOut_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x060078FB RID: 30971 RVA: 0x00230124 File Offset: 0x0022E324
		// (set) Token: 0x060078FC RID: 30972 RVA: 0x00041706 File Offset: 0x0003F906
		public unsafe bool notWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut_Behaviour.NativeFieldInfoPtr_notWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut_Behaviour.NativeFieldInfoPtr_notWait)) = value;
			}
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x060078FD RID: 30973 RVA: 0x0023014C File Offset: 0x0022E34C
		// (set) Token: 0x060078FE RID: 30974 RVA: 0x00041721 File Offset: 0x0003F921
		public unsafe COM_AFadeInFadeOut_Behaviour.Type transitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut_Behaviour.NativeFieldInfoPtr_transitionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_AFadeInFadeOut_Behaviour.NativeFieldInfoPtr_transitionType)) = value;
			}
		}

		// Token: 0x04004FAE RID: 20398
		private static readonly IntPtr NativeFieldInfoPtr_notWait;

		// Token: 0x04004FAF RID: 20399
		private static readonly IntPtr NativeFieldInfoPtr_transitionType;

		// Token: 0x04004FB0 RID: 20400
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FB1 RID: 20401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004FB2 RID: 20402
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000F85 RID: 3973
		public enum Type
		{
			// Token: 0x0400AE18 RID: 44568
			FadeIn,
			// Token: 0x0400AE19 RID: 44569
			FadeOut
		}
	}
}
