using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000420 RID: 1056
	public class COM_Camera_WorldPos_Set_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x0600784E RID: 30798 RVA: 0x0022E4C4 File Offset: 0x0022C6C4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_Camera_WorldPos_Set_Behaviour()
		{
			Il2CppClassPointerStore<COM_Camera_WorldPos_Set_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_Camera_WorldPos_Set_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_Camera_WorldPos_Set_Behaviour>.NativeClassPtr);
			COM_Camera_WorldPos_Set_Behaviour.NativeFieldInfoPtr_damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Set_Behaviour>.NativeClassPtr, "damping");
			COM_Camera_WorldPos_Set_Behaviour.NativeFieldInfoPtr_targetCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_Camera_WorldPos_Set_Behaviour>.NativeClassPtr, "targetCoordinate");
			COM_Camera_WorldPos_Set_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Set_Behaviour>.NativeClassPtr, 100687623);
			COM_Camera_WorldPos_Set_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_Camera_WorldPos_Set_Behaviour>.NativeClassPtr, 100687624);
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x0022E544 File Offset: 0x0022C744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293500, XrefRangeEnd = 293505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_Camera_WorldPos_Set_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x0022E580 File Offset: 0x0022C780
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_Camera_WorldPos_Set_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_Camera_WorldPos_Set_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_Camera_WorldPos_Set_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x0004116A File Offset: 0x0003F36A
		public COM_Camera_WorldPos_Set_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x0022E5BC File Offset: 0x0022C7BC
		// (set) Token: 0x06007853 RID: 30803 RVA: 0x00041173 File Offset: 0x0003F373
		public unsafe float damping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set_Behaviour.NativeFieldInfoPtr_damping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set_Behaviour.NativeFieldInfoPtr_damping)) = value;
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x0022E5E4 File Offset: 0x0022C7E4
		// (set) Token: 0x06007855 RID: 30805 RVA: 0x0004118E File Offset: 0x0003F38E
		public unsafe Vector2 targetCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set_Behaviour.NativeFieldInfoPtr_targetCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_Camera_WorldPos_Set_Behaviour.NativeFieldInfoPtr_targetCoordinate)) = value;
			}
		}

		// Token: 0x04004F58 RID: 20312
		private static readonly IntPtr NativeFieldInfoPtr_damping;

		// Token: 0x04004F59 RID: 20313
		private static readonly IntPtr NativeFieldInfoPtr_targetCoordinate;

		// Token: 0x04004F5A RID: 20314
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F5B RID: 20315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
