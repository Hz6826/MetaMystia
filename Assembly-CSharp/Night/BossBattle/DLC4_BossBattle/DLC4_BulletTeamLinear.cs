using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000078 RID: 120
	public class DLC4_BulletTeamLinear : DLC4_BulletTeam
	{
		// Token: 0x06000CC4 RID: 3268 RVA: 0x000C8FB8 File Offset: 0x000C71B8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BulletTeamLinear()
		{
			Il2CppClassPointerStore<DLC4_BulletTeamLinear>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BulletTeamLinear");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BulletTeamLinear>.NativeClassPtr);
			DLC4_BulletTeamLinear.NativeFieldInfoPtr_OverrideMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BulletTeamLinear>.NativeClassPtr, "OverrideMoveDirection");
			DLC4_BulletTeamLinear.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamLinear>.NativeClassPtr, 100665463);
			DLC4_BulletTeamLinear.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamLinear>.NativeClassPtr, 100665464);
			DLC4_BulletTeamLinear.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BulletTeamLinear>.NativeClassPtr, 100665465);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000C9038 File Offset: 0x000C7238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43819, RefRangeEnd = 43820, XrefRangeStart = 43805, XrefRangeEnd = 43819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeamLinear.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000C9074 File Offset: 0x000C7274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43820, XrefRangeEnd = 43821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BulletTeamLinear.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000C90B0 File Offset: 0x000C72B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43417, RefRangeEnd = 43418, XrefRangeStart = 43417, XrefRangeEnd = 43418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BulletTeamLinear() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BulletTeamLinear>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BulletTeamLinear.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00008B1B File Offset: 0x00006D1B
		public DLC4_BulletTeamLinear(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000C90EC File Offset: 0x000C72EC
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00008B24 File Offset: 0x00006D24
		public Nullable<Vector2> OverrideMoveDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamLinear.NativeFieldInfoPtr_OverrideMoveDirection);
				return new Nullable<Vector2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BulletTeamLinear.NativeFieldInfoPtr_OverrideMoveDirection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr_OverrideMoveDirection;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
