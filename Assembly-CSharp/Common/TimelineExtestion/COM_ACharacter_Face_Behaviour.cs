using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000434 RID: 1076
	public class COM_ACharacter_Face_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078FF RID: 30975 RVA: 0x00230174 File Offset: 0x0022E374
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Face_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_Face_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Face_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Face_Behaviour>.NativeClassPtr);
			COM_ACharacter_Face_Behaviour.NativeFieldInfoPtr_faceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Face_Behaviour>.NativeClassPtr, "faceID");
			COM_ACharacter_Face_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Face_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_Face_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Face_Behaviour>.NativeClassPtr, 100687680);
			COM_ACharacter_Face_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Face_Behaviour>.NativeClassPtr, 100687681);
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x002301F4 File Offset: 0x0022E3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293791, XrefRangeEnd = 293796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Face_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00230230 File Offset: 0x0022E430
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Face_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Face_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Face_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x0004173C File Offset: 0x0003F93C
		public COM_ACharacter_Face_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x06007903 RID: 30979 RVA: 0x0023026C File Offset: 0x0022E46C
		// (set) Token: 0x06007904 RID: 30980 RVA: 0x00041745 File Offset: 0x0003F945
		public unsafe COM_ACharacter_Face_Behaviour.FaceID faceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face_Behaviour.NativeFieldInfoPtr_faceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face_Behaviour.NativeFieldInfoPtr_faceID)) = value;
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x06007905 RID: 30981 RVA: 0x00230294 File Offset: 0x0022E494
		// (set) Token: 0x06007906 RID: 30982 RVA: 0x00041760 File Offset: 0x0003F960
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Face_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004FB3 RID: 20403
		private static readonly IntPtr NativeFieldInfoPtr_faceID;

		// Token: 0x04004FB4 RID: 20404
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004FB5 RID: 20405
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FB6 RID: 20406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F86 RID: 3974
		public enum FaceID : byte
		{
			// Token: 0x0400AE1B RID: 44571
			I,
			// Token: 0x0400AE1C RID: 44572
			II,
			// Token: 0x0400AE1D RID: 44573
			III,
			// Token: 0x0400AE1E RID: 44574
			IV
		}
	}
}
