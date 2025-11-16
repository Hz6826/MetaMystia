using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000422 RID: 1058
	public class COM_Camera_WorldPos_Follow_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600785E RID: 30814 RVA: 0x0022E754 File Offset: 0x0022C954
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_WorldPos_Follow_Behaviour()
		{
			Il2CppClassPointerStore<COM_Camera_WorldPos_Follow_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_WorldPos_Follow_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow_Behaviour>.NativeClassPtr);
			COM_Camera_WorldPos_Follow_Behaviour.NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow_Behaviour>.NativeClassPtr, "damping");
			COM_Camera_WorldPos_Follow_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow_Behaviour>.NativeClassPtr, "label");
			COM_Camera_WorldPos_Follow_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow_Behaviour>.NativeClassPtr, 100687627);
			COM_Camera_WorldPos_Follow_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow_Behaviour>.NativeClassPtr, 100687628);
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x0022E7D4 File Offset: 0x0022C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293509, XrefRangeEnd = 293514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_WorldPos_Follow_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x0022E810 File Offset: 0x0022CA10
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_WorldPos_Follow_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_WorldPos_Follow_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_WorldPos_Follow_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x000411E8 File Offset: 0x0003F3E8
		public COM_Camera_WorldPos_Follow_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x06007862 RID: 30818 RVA: 0x0022E84C File Offset: 0x0022CA4C
		// (set) Token: 0x06007863 RID: 30819 RVA: 0x000411F1 File Offset: 0x0003F3F1
		public unsafe float damping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow_Behaviour.NativeFieldInfoPtr_damping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow_Behaviour.NativeFieldInfoPtr_damping)) = value;
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x06007864 RID: 30820 RVA: 0x0022E874 File Offset: 0x0022CA74
		// (set) Token: 0x06007865 RID: 30821 RVA: 0x0004120C File Offset: 0x0003F40C
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Follow_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004F60 RID: 20320
		private static readonly IntPtr NativeFieldInfoPtr_damping;

		// Token: 0x04004F61 RID: 20321
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F62 RID: 20322
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F63 RID: 20323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
