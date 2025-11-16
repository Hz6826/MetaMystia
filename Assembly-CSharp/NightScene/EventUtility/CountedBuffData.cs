using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace NightScene.EventUtility
{
	// Token: 0x020001AD RID: 429
	public sealed class CountedBuffData : ValueType
	{
		// Token: 0x060033FF RID: 13311 RVA: 0x0015138C File Offset: 0x0014F58C
		// Note: this type is marked as 'beforefieldinit'.
		static CountedBuffData()
		{
			Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.EventUtility", "CountedBuffData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr);
			CountedBuffData.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr, "count");
			CountedBuffData.NativeFieldInfoPtr_onBuffCountUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr, "onBuffCountUpdateCallback");
			CountedBuffData.NativeFieldInfoPtr_onBuffDeductCallBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr, "onBuffDeductCallBack");
			CountedBuffData.NativeFieldInfoPtr_onBuffEndCallBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr, "onBuffEndCallBack");
			CountedBuffData.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr, "guid");
			CountedBuffData.NativeFieldInfoPtr_allowZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr, "allowZero");
			CountedBuffData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Action_1_Int32_Action_Action_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr, 100673253);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00151448 File Offset: 0x0014F648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123813, RefRangeEnd = 123814, XrefRangeStart = 123810, XrefRangeEnd = 123813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountedBuffData(int count, Action<int> onBuffCountUpdateCallback, Action onBuffDeductCallBack, Action onBuffEndCallBack, Guid guid, bool allowZero) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffCountUpdateCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffDeductCallBack);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuffEndCallBack);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowZero;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountedBuffData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Action_1_Int32_Action_Action_Guid_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x0001CE8A File Offset: 0x0001B08A
		public CountedBuffData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x0001CE93 File Offset: 0x0001B093
		public CountedBuffData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountedBuffData>.NativeClassPtr))
		{
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x001514E8 File Offset: 0x0014F6E8
		// (set) Token: 0x06003404 RID: 13316 RVA: 0x0001CEA5 File Offset: 0x0001B0A5
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06003405 RID: 13317 RVA: 0x00151510 File Offset: 0x0014F710
		// (set) Token: 0x06003406 RID: 13318 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		public unsafe Action<int> onBuffCountUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_onBuffCountUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_onBuffCountUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x00151540 File Offset: 0x0014F740
		// (set) Token: 0x06003408 RID: 13320 RVA: 0x0001CEDF File Offset: 0x0001B0DF
		public unsafe Action onBuffDeductCallBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_onBuffDeductCallBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_onBuffDeductCallBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x00151570 File Offset: 0x0014F770
		// (set) Token: 0x0600340A RID: 13322 RVA: 0x0001CEFE File Offset: 0x0001B0FE
		public unsafe Action onBuffEndCallBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_onBuffEndCallBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_onBuffEndCallBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x001515A0 File Offset: 0x0014F7A0
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x0001CF1D File Offset: 0x0001B11D
		public unsafe Guid guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_guid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_guid)) = value;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x001515C8 File Offset: 0x0014F7C8
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x0001CF38 File Offset: 0x0001B138
		public unsafe bool allowZero
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_allowZero);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountedBuffData.NativeFieldInfoPtr_allowZero)) = value;
			}
		}

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeFieldInfoPtr_onBuffCountUpdateCallback;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeFieldInfoPtr_onBuffDeductCallBack;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeFieldInfoPtr_onBuffEndCallBack;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeFieldInfoPtr_guid;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeFieldInfoPtr_allowZero;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Action_1_Int32_Action_Action_Guid_Boolean_0;
	}
}
