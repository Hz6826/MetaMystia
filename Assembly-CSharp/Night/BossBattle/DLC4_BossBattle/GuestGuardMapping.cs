using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000083 RID: 131
	[Serializable]
	public sealed class GuestGuardMapping : ValueType
	{
		// Token: 0x06000D5D RID: 3421 RVA: 0x000CB148 File Offset: 0x000C9348
		// Note: this type is marked as 'beforefieldinit'.
		static GuestGuardMapping()
		{
			Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "GuestGuardMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr);
			GuestGuardMapping.NativeFieldInfoPtr_letterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "letterId");
			GuestGuardMapping.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "id");
			GuestGuardMapping.NativeFieldInfoPtr_costP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "costP");
			GuestGuardMapping.NativeFieldInfoPtr_coolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "coolDown");
			GuestGuardMapping.NativeFieldInfoPtr_maxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "maxHp");
			GuestGuardMapping.NativeFieldInfoPtr_guardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "guardType");
			GuestGuardMapping.NativeFieldInfoPtr_youseiOrderBevId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "youseiOrderBevId");
			GuestGuardMapping.NativeFieldInfoPtr_guardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "guardController");
			GuestGuardMapping.NativeFieldInfoPtr_inviteEventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "inviteEventLabel");
			GuestGuardMapping.NativeFieldInfoPtr__DescribeText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, "<DescribeText>k__BackingField");
			GuestGuardMapping.NativeMethodInfoPtr_get_DescribeText_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, 100665557);
			GuestGuardMapping.NativeMethodInfoPtr_set_DescribeText_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, 100665558);
			GuestGuardMapping.NativeMethodInfoPtr_Equals_Public_Boolean_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, 100665559);
			GuestGuardMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, 100665560);
			GuestGuardMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, 100665561);
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x000CB2A4 File Offset: 0x000C94A4
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x000CB2E8 File Offset: 0x000C94E8
		public unsafe Il2CppStringArray DescribeText
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMapping.NativeMethodInfoPtr_get_DescribeText_Public_get_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMapping.NativeMethodInfoPtr_set_DescribeText_Public_set_Void_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000CB330 File Offset: 0x000C9530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44158, XrefRangeEnd = 44160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GuestGuardMapping other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMapping.NativeMethodInfoPtr_Equals_Public_Boolean_GuestGuardMapping_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x000CB388 File Offset: 0x000C9588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44160, XrefRangeEnd = 44165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000CB3DC File Offset: 0x000C95DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44165, XrefRangeEnd = 44171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestGuardMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00008F1F File Offset: 0x0000711F
		public GuestGuardMapping(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00008F28 File Offset: 0x00007128
		public GuestGuardMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr))
		{
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000CB420 File Offset: 0x000C9620
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00008F3A File Offset: 0x0000713A
		public unsafe int letterId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_letterId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_letterId)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000CB448 File Offset: 0x000C9648
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00008F55 File Offset: 0x00007155
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000CB470 File Offset: 0x000C9670
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x00008F70 File Offset: 0x00007170
		public unsafe int costP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_costP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_costP)) = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000CB498 File Offset: 0x000C9698
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x00008F8B File Offset: 0x0000718B
		public unsafe float coolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_coolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_coolDown)) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000CB4C0 File Offset: 0x000C96C0
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x00008FA6 File Offset: 0x000071A6
		public unsafe int maxHp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_maxHp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_maxHp)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x000CB4E8 File Offset: 0x000C96E8
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x00008FC1 File Offset: 0x000071C1
		public unsafe GuestGuardMapping.GuardType guardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_guardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_guardType)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000CB510 File Offset: 0x000C9710
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00008FDC File Offset: 0x000071DC
		public unsafe int youseiOrderBevId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_youseiOrderBevId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_youseiOrderBevId)) = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x000CB538 File Offset: 0x000C9738
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x00008FF7 File Offset: 0x000071F7
		public unsafe GameObject guardController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_guardController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_guardController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x000CB568 File Offset: 0x000C9768
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x00009016 File Offset: 0x00007216
		public unsafe string inviteEventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_inviteEventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr_inviteEventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000CB590 File Offset: 0x000C9790
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00009035 File Offset: 0x00007235
		public unsafe Il2CppStringArray _DescribeText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr__DescribeText_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestGuardMapping.NativeFieldInfoPtr__DescribeText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_letterId;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_costP;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_coolDown;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_maxHp;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_guardType;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_youseiOrderBevId;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_guardController;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_inviteEventLabel;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr__DescribeText_k__BackingField;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_get_DescribeText_Public_get_Il2CppStringArray_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_set_DescribeText_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_GuestGuardMapping_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x02000549 RID: 1353
		public enum GuardType
		{
			// Token: 0x040058BA RID: 22714
			Hero,
			// Token: 0x040058BB RID: 22715
			Yousei,
			// Token: 0x040058BC RID: 22716
			Other
		}
	}
}
