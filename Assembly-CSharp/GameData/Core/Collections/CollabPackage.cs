using System;
using System.Runtime.InteropServices;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections
{
	// Token: 0x0200023D RID: 573
	[Serializable]
	public class CollabPackage : Object
	{
		// Token: 0x060047A5 RID: 18341 RVA: 0x00196B38 File Offset: 0x00194D38
		// Note: this type is marked as 'beforefieldinit'.
		static CollabPackage()
		{
			Il2CppClassPointerStore<CollabPackage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "CollabPackage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr);
			CollabPackage.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "label");
			CollabPackage.NativeFieldInfoPtr_headerKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "headerKey");
			CollabPackage.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "enabled");
			CollabPackage.NativeFieldInfoPtr_rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "rules");
			CollabPackage.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "time");
			CollabPackage.NativeFieldInfoPtr_collablAdvDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "collablAdvDialog");
			CollabPackage.NativeFieldInfoPtr_openCollabDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "openCollabDialog");
			CollabPackage.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, 100677649);
			CollabPackage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, 100677650);
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00196C1C File Offset: 0x00194E1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189513, RefRangeEnd = 189515, XrefRangeStart = 189512, XrefRangeEnd = 189513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabPackage.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x00196C58 File Offset: 0x00194E58
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollabPackage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabPackage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00024E37 File Offset: 0x00023037
		public CollabPackage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x00196C94 File Offset: 0x00194E94
		// (set) Token: 0x060047AA RID: 18346 RVA: 0x00024E40 File Offset: 0x00023040
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x00196CBC File Offset: 0x00194EBC
		// (set) Token: 0x060047AC RID: 18348 RVA: 0x00024E5F File Offset: 0x0002305F
		public unsafe string headerKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_headerKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_headerKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x00196CE4 File Offset: 0x00194EE4
		// (set) Token: 0x060047AE RID: 18350 RVA: 0x00024E7E File Offset: 0x0002307E
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x00196D0C File Offset: 0x00194F0C
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x00024E99 File Offset: 0x00023099
		public unsafe Il2CppReferenceArray<CollabPackage.CollabRule> rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CollabPackage.CollabRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x060047B1 RID: 18353 RVA: 0x00196D3C File Offset: 0x00194F3C
		// (set) Token: 0x060047B2 RID: 18354 RVA: 0x00024EB8 File Offset: 0x000230B8
		public unsafe CollabPackage.TimeRange time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x00196D64 File Offset: 0x00194F64
		// (set) Token: 0x060047B4 RID: 18356 RVA: 0x00024ED3 File Offset: 0x000230D3
		public unsafe DialogPackage collablAdvDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_collablAdvDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_collablAdvDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x00196D94 File Offset: 0x00194F94
		// (set) Token: 0x060047B6 RID: 18358 RVA: 0x00024EF2 File Offset: 0x000230F2
		public unsafe DialogPackage openCollabDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_openCollabDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.NativeFieldInfoPtr_openCollabDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeFieldInfoPtr_headerKey;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeFieldInfoPtr_rules;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeFieldInfoPtr_collablAdvDialog;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeFieldInfoPtr_openCollabDialog;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB3 RID: 2739
		[Serializable]
		public sealed class CollabRule : ValueType
		{
			// Token: 0x0600CDAE RID: 52654 RVA: 0x0032B630 File Offset: 0x00329830
			// Note: this type is marked as 'beforefieldinit'.
			static CollabRule()
			{
				Il2CppClassPointerStore<CollabPackage.CollabRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "CollabRule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabPackage.CollabRule>.NativeClassPtr);
				CollabPackage.CollabRule.NativeFieldInfoPtr_ruleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.CollabRule>.NativeClassPtr, "ruleType");
				CollabPackage.CollabRule.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.CollabRule>.NativeClassPtr, "key");
			}

			// Token: 0x0600CDAF RID: 52655 RVA: 0x0006E321 File Offset: 0x0006C521
			public CollabRule(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CDB0 RID: 52656 RVA: 0x0006E32A File Offset: 0x0006C52A
			public CollabRule() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabPackage.CollabRule>.NativeClassPtr))
			{
			}

			// Token: 0x170042DD RID: 17117
			// (get) Token: 0x0600CDB1 RID: 52657 RVA: 0x0032B684 File Offset: 0x00329884
			// (set) Token: 0x0600CDB2 RID: 52658 RVA: 0x0006E33C File Offset: 0x0006C53C
			public unsafe CollabPackage.CollabRule.RuleType ruleType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.CollabRule.NativeFieldInfoPtr_ruleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.CollabRule.NativeFieldInfoPtr_ruleType)) = value;
				}
			}

			// Token: 0x170042DE RID: 17118
			// (get) Token: 0x0600CDB3 RID: 52659 RVA: 0x0032B6AC File Offset: 0x003298AC
			// (set) Token: 0x0600CDB4 RID: 52660 RVA: 0x0006E357 File Offset: 0x0006C557
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.CollabRule.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabPackage.CollabRule.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400842E RID: 33838
			private static readonly IntPtr NativeFieldInfoPtr_ruleType;

			// Token: 0x0400842F RID: 33839
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x02001016 RID: 4118
			public enum RuleType
			{
				// Token: 0x0400B238 RID: 45624
				SpecialNPCToggle,
				// Token: 0x0400B239 RID: 45625
				InteractableSwitch
			}
		}

		// Token: 0x02000AB4 RID: 2740
		[Serializable]
		[StructLayout(2)]
		public struct TimeRange
		{
			// Token: 0x0600CDB5 RID: 52661 RVA: 0x0032B6D4 File Offset: 0x003298D4
			// Note: this type is marked as 'beforefieldinit'.
			static TimeRange()
			{
				Il2CppClassPointerStore<CollabPackage.TimeRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "TimeRange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabPackage.TimeRange>.NativeClassPtr);
				CollabPackage.TimeRange.NativeFieldInfoPtr_useTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.TimeRange>.NativeClassPtr, "useTime");
				CollabPackage.TimeRange.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.TimeRange>.NativeClassPtr, "min");
				CollabPackage.TimeRange.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.TimeRange>.NativeClassPtr, "max");
			}

			// Token: 0x0600CDB6 RID: 52662 RVA: 0x0006E376 File Offset: 0x0006C576
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollabPackage.TimeRange>.NativeClassPtr, ref this));
			}

			// Token: 0x04008430 RID: 33840
			private static readonly IntPtr NativeFieldInfoPtr_useTime;

			// Token: 0x04008431 RID: 33841
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x04008432 RID: 33842
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x04008433 RID: 33843
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool useTime;

			// Token: 0x04008434 RID: 33844
			[FieldOffset(2)]
			public CollabPackage.Time min;

			// Token: 0x04008435 RID: 33845
			[FieldOffset(6)]
			public CollabPackage.Time max;
		}

		// Token: 0x02000AB5 RID: 2741
		[Serializable]
		[StructLayout(2)]
		public struct Time
		{
			// Token: 0x0600CDB7 RID: 52663 RVA: 0x0032B73C File Offset: 0x0032993C
			// Note: this type is marked as 'beforefieldinit'.
			static Time()
			{
				Il2CppClassPointerStore<CollabPackage.Time>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollabPackage>.NativeClassPtr, "Time");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabPackage.Time>.NativeClassPtr);
				CollabPackage.Time.NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.Time>.NativeClassPtr, "year");
				CollabPackage.Time.NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.Time>.NativeClassPtr, "month");
				CollabPackage.Time.NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabPackage.Time>.NativeClassPtr, "day");
			}

			// Token: 0x0600CDB8 RID: 52664 RVA: 0x0006E388 File Offset: 0x0006C588
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollabPackage.Time>.NativeClassPtr, ref this));
			}

			// Token: 0x04008436 RID: 33846
			private static readonly IntPtr NativeFieldInfoPtr_year;

			// Token: 0x04008437 RID: 33847
			private static readonly IntPtr NativeFieldInfoPtr_month;

			// Token: 0x04008438 RID: 33848
			private static readonly IntPtr NativeFieldInfoPtr_day;

			// Token: 0x04008439 RID: 33849
			[FieldOffset(0)]
			public short year;

			// Token: 0x0400843A RID: 33850
			[FieldOffset(2)]
			public byte month;

			// Token: 0x0400843B RID: 33851
			[FieldOffset(3)]
			public byte day;
		}
	}
}
