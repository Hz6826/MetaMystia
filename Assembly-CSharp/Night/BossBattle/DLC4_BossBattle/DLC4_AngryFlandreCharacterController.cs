using System;
using Common.Audio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000092 RID: 146
	public class DLC4_AngryFlandreCharacterController : DLC4_FlandreEnemyCharacterController
	{
		// Token: 0x06000ECC RID: 3788 RVA: 0x000D0620 File Offset: 0x000CE820
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_AngryFlandreCharacterController()
		{
			Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_AngryFlandreCharacterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr);
			DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_FireHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr, "m_FireHit");
			DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr, "m_Offset");
			DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_LarventinSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr, "m_LarventinSfx");
			DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_FireSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr, "m_FireSfx");
			DLC4_AngryFlandreCharacterController.NativeMethodInfoPtr_OnAttack_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr, 100665902);
			DLC4_AngryFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr, 100665903);
			DLC4_AngryFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr, 100665904);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000D06DC File Offset: 0x000CE8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47480, XrefRangeEnd = 47499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_AngryFlandreCharacterController.NativeMethodInfoPtr_OnAttack_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000D0718 File Offset: 0x000CE918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47499, XrefRangeEnd = 47500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_AngryFlandreCharacterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000D0754 File Offset: 0x000CE954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_AngryFlandreCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_AngryFlandreCharacterController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_AngryFlandreCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00009A14 File Offset: 0x00007C14
		public DLC4_AngryFlandreCharacterController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000D0790 File Offset: 0x000CE990
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00009A1D File Offset: 0x00007C1D
		public VFXPrefab m_FireHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_FireHit);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_FireHit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x000D07C0 File Offset: 0x000CE9C0
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00009A4B File Offset: 0x00007C4B
		public unsafe Vector2 m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000D07E8 File Offset: 0x000CE9E8
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00009A66 File Offset: 0x00007C66
		public GlobalAudioManager.DelayAudioClip m_LarventinSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_LarventinSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_LarventinSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x000D0818 File Offset: 0x000CEA18
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00009A94 File Offset: 0x00007C94
		public GlobalAudioManager.DelayAudioClip m_FireSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_FireSfx);
				return new GlobalAudioManager.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_AngryFlandreCharacterController.NativeFieldInfoPtr_m_FireSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalAudioManager.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_m_FireHit;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr_m_LarventinSfx;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr_m_FireSfx;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_OnAttack_Protected_Virtual_Void_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
