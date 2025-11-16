using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Common.TimelineExtestion
{
	// Token: 0x02000430 RID: 1072
	public class COM_ACharacter_SetVisualActive_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060078DC RID: 30940 RVA: 0x0022FBD0 File Offset: 0x0022DDD0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SetVisualActive_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_SetVisualActive_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SetVisualActive_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive_Behaviour>.NativeClassPtr);
			COM_ACharacter_SetVisualActive_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_SetVisualActive_Behaviour.NativeFieldInfoPtr_visualActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive_Behaviour>.NativeClassPtr, "visualActive");
			COM_ACharacter_SetVisualActive_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive_Behaviour>.NativeClassPtr, 100687671);
			COM_ACharacter_SetVisualActive_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive_Behaviour>.NativeClassPtr, 100687672);
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x0022FC50 File Offset: 0x0022DE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293733, XrefRangeEnd = 293738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SetVisualActive_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x0022FC8C File Offset: 0x0022DE8C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SetVisualActive_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SetVisualActive_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetVisualActive_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x00041615 File Offset: 0x0003F815
		public COM_ACharacter_SetVisualActive_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x0022FCC8 File Offset: 0x0022DEC8
		// (set) Token: 0x060078E1 RID: 30945 RVA: 0x0004161E File Offset: 0x0003F81E
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x060078E2 RID: 30946 RVA: 0x0022FCF0 File Offset: 0x0022DEF0
		// (set) Token: 0x060078E3 RID: 30947 RVA: 0x0004163D File Offset: 0x0003F83D
		public unsafe bool visualActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive_Behaviour.NativeFieldInfoPtr_visualActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetVisualActive_Behaviour.NativeFieldInfoPtr_visualActive)) = value;
			}
		}

		// Token: 0x04004FA1 RID: 20385
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004FA2 RID: 20386
		private static readonly IntPtr NativeFieldInfoPtr_visualActive;

		// Token: 0x04004FA3 RID: 20387
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FA4 RID: 20388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
