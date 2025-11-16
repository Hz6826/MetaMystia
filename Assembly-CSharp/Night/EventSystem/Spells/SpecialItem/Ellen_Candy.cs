using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.EventSystem.Spells.SpecialItem
{
	// Token: 0x02000052 RID: 82
	public class Ellen_Candy : MonoBehaviour
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x000BFF1C File Offset: 0x000BE11C
		// Note: this type is marked as 'beforefieldinit'.
		static Ellen_Candy()
		{
			Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.EventSystem.Spells.SpecialItem", "Ellen_Candy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr);
			Ellen_Candy.NativeFieldInfoPtr_lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "lifeTime");
			Ellen_Candy.NativeFieldInfoPtr_swallowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "swallowSpeed");
			Ellen_Candy.NativeFieldInfoPtr_swallowRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "swallowRadius");
			Ellen_Candy.NativeFieldInfoPtr_leftTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "leftTime");
			Ellen_Candy.NativeFieldInfoPtr_swallowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "swallowMode");
			Ellen_Candy.NativeFieldInfoPtr_hasDisappear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "hasDisappear");
			Ellen_Candy.NativeFieldInfoPtr_playerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "playerTransform");
			Ellen_Candy.NativeFieldInfoPtr_OnPlayerGetCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, "OnPlayerGetCallback");
			Ellen_Candy.NativeMethodInfoPtr_add_OnPlayerGetCallback_Public_add_Void_Action_1_Ellen_Candy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665053);
			Ellen_Candy.NativeMethodInfoPtr_remove_OnPlayerGetCallback_Public_rem_Void_Action_1_Ellen_Candy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665054);
			Ellen_Candy.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665055);
			Ellen_Candy.NativeMethodInfoPtr_SetPlayerTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665056);
			Ellen_Candy.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665057);
			Ellen_Candy.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665058);
			Ellen_Candy.NativeMethodInfoPtr_Get_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665059);
			Ellen_Candy.NativeMethodInfoPtr_DisAppear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665060);
			Ellen_Candy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr, 100665061);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000C00A0 File Offset: 0x000BE2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40320, RefRangeEnd = 40321, XrefRangeStart = 40315, XrefRangeEnd = 40320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnPlayerGetCallback(Action<Ellen_Candy> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_add_OnPlayerGetCallback_Public_add_Void_Action_1_Ellen_Candy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000C00E4 File Offset: 0x000BE2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40321, XrefRangeEnd = 40326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnPlayerGetCallback(Action<Ellen_Candy> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_remove_OnPlayerGetCallback_Public_rem_Void_Action_1_Ellen_Candy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000C0128 File Offset: 0x000BE328
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000C015C File Offset: 0x000BE35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40326, XrefRangeEnd = 40327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerTransform(Transform player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_SetPlayerTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000C01A0 File Offset: 0x000BE3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40327, XrefRangeEnd = 40337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000C01D4 File Offset: 0x000BE3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40337, XrefRangeEnd = 40340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000C0218 File Offset: 0x000BE418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40340, XrefRangeEnd = 40345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_Get_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000C024C File Offset: 0x000BE44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40345, XrefRangeEnd = 40350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisAppear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr_DisAppear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000C0280 File Offset: 0x000BE480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40350, XrefRangeEnd = 40351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ellen_Candy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ellen_Candy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ellen_Candy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00007DAA File Offset: 0x00005FAA
		public Ellen_Candy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000C02BC File Offset: 0x000BE4BC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00007DB3 File Offset: 0x00005FB3
		public unsafe int lifeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_lifeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_lifeTime)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x000C02E4 File Offset: 0x000BE4E4
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00007DCE File Offset: 0x00005FCE
		public unsafe float swallowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_swallowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_swallowSpeed)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x000C030C File Offset: 0x000BE50C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00007DE9 File Offset: 0x00005FE9
		public unsafe float swallowRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_swallowRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_swallowRadius)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000C0334 File Offset: 0x000BE534
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00007E04 File Offset: 0x00006004
		public unsafe float leftTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_leftTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_leftTime)) = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000C035C File Offset: 0x000BE55C
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00007E1F File Offset: 0x0000601F
		public unsafe bool swallowMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_swallowMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_swallowMode)) = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000C0384 File Offset: 0x000BE584
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00007E3A File Offset: 0x0000603A
		public unsafe bool hasDisappear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_hasDisappear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_hasDisappear)) = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x000C03AC File Offset: 0x000BE5AC
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00007E55 File Offset: 0x00006055
		public unsafe Transform playerTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_playerTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_playerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x000C03DC File Offset: 0x000BE5DC
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00007E74 File Offset: 0x00006074
		public unsafe Action<Ellen_Candy> OnPlayerGetCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_OnPlayerGetCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Ellen_Candy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ellen_Candy.NativeFieldInfoPtr_OnPlayerGetCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_lifeTime;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_swallowSpeed;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_swallowRadius;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_leftTime;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_swallowMode;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr_hasDisappear;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_playerTransform;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerGetCallback;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPlayerGetCallback_Public_add_Void_Action_1_Ellen_Candy_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPlayerGetCallback_Public_rem_Void_Action_1_Ellen_Candy_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerTransform_Public_Void_Transform_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_Collider2D_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Void_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_DisAppear_Private_Void_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
