using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x02000171 RID: 369
	public class StorageConditionComponent : EntityConditionComponent
	{
		// Token: 0x060028C9 RID: 10441 RVA: 0x001262C8 File Offset: 0x001244C8
		// Note: this type is marked as 'beforefieldinit'.
		static StorageConditionComponent()
		{
			Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "StorageConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr);
			StorageConditionComponent.NativeFieldInfoPtr_mustHaveProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr, "mustHaveProducts");
			StorageConditionComponent.NativeFieldInfoPtr_alternativeOptionsProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr, "alternativeOptionsProducts");
			StorageConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr, 100670432);
			StorageConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr, 100670433);
			StorageConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr, 100670434);
			StorageConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr, 100670435);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00126370 File Offset: 0x00124570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92509, XrefRangeEnd = 92531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x001263B8 File Offset: 0x001245B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92531, XrefRangeEnd = 92537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x00126404 File Offset: 0x00124604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92537, XrefRangeEnd = 92541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00126440 File Offset: 0x00124640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92541, XrefRangeEnd = 92549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00017E81 File Offset: 0x00016081
		public StorageConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x0012647C File Offset: 0x0012467C
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x00017E8A File Offset: 0x0001608A
		public unsafe Il2CppReferenceArray<Product> mustHaveProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageConditionComponent.NativeFieldInfoPtr_mustHaveProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageConditionComponent.NativeFieldInfoPtr_mustHaveProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x001264AC File Offset: 0x001246AC
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x00017EA9 File Offset: 0x000160A9
		public unsafe Il2CppReferenceArray<Product> alternativeOptionsProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageConditionComponent.NativeFieldInfoPtr_alternativeOptionsProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageConditionComponent.NativeFieldInfoPtr_alternativeOptionsProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeFieldInfoPtr_mustHaveProducts;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeFieldInfoPtr_alternativeOptionsProducts;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000791 RID: 1937
		[ObfuscatedName("DayScene.Interactables.Collections.ConditionComponents.StorageConditionComponent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600A385 RID: 41861 RVA: 0x002ADE90 File Offset: 0x002AC090
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageConditionComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr);
				StorageConditionComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, "<>9");
				StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, "<>9__2_0");
				StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, "<>9__2_1");
				StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, "<>9__2_2");
				StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, "<>9__2_3");
				StorageConditionComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, 100670437);
				StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_0_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, 100670438);
				StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_1_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, 100670439);
				StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_2_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, 100670440);
				StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_3_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr, 100670441);
			}

			// Token: 0x0600A386 RID: 41862 RVA: 0x002ADF84 File Offset: 0x002AC184
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageConditionComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageConditionComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A387 RID: 41863 RVA: 0x002ADFC0 File Offset: 0x002AC1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92508, XrefRangeEnd = 92509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnGetAvailability_b__2_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_0_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A388 RID: 41864 RVA: 0x002AE014 File Offset: 0x002AC214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnGetAvailability_b__2_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_1_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A389 RID: 41865 RVA: 0x002AE068 File Offset: 0x002AC268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnGetAvailability_b__2_2(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_2_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A38A RID: 41866 RVA: 0x002AE0BC File Offset: 0x002AC2BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnGetAvailability_b__2_3(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageConditionComponent.__c.NativeMethodInfoPtr__OnGetAvailability_b__2_3_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A38B RID: 41867 RVA: 0x000584F2 File Offset: 0x000566F2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035EE RID: 13806
			// (get) Token: 0x0600A38C RID: 41868 RVA: 0x002AE110 File Offset: 0x002AC310
			// (set) Token: 0x0600A38D RID: 41869 RVA: 0x000584FB File Offset: 0x000566FB
			public unsafe static StorageConditionComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageConditionComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035EF RID: 13807
			// (get) Token: 0x0600A38E RID: 41870 RVA: 0x002AE138 File Offset: 0x002AC338
			// (set) Token: 0x0600A38F RID: 41871 RVA: 0x0005850D File Offset: 0x0005670D
			public unsafe static Func<Product, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035F0 RID: 13808
			// (get) Token: 0x0600A390 RID: 41872 RVA: 0x002AE160 File Offset: 0x002AC360
			// (set) Token: 0x0600A391 RID: 41873 RVA: 0x0005851F File Offset: 0x0005671F
			public unsafe static Func<Product, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035F1 RID: 13809
			// (get) Token: 0x0600A392 RID: 41874 RVA: 0x002AE188 File Offset: 0x002AC388
			// (set) Token: 0x0600A393 RID: 41875 RVA: 0x00058531 File Offset: 0x00056731
			public unsafe static Func<Product, bool> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035F2 RID: 13810
			// (get) Token: 0x0600A394 RID: 41876 RVA: 0x002AE1B0 File Offset: 0x002AC3B0
			// (set) Token: 0x0600A395 RID: 41877 RVA: 0x00058543 File Offset: 0x00056743
			public unsafe static Func<Product, bool> __9__2_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageConditionComponent.__c.NativeFieldInfoPtr___9__2_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069D9 RID: 27097
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040069DA RID: 27098
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040069DB RID: 27099
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x040069DC RID: 27100
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x040069DD RID: 27101
			private static readonly IntPtr NativeFieldInfoPtr___9__2_3;

			// Token: 0x040069DE RID: 27102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069DF RID: 27103
			private static readonly IntPtr NativeMethodInfoPtr__OnGetAvailability_b__2_0_Internal_Boolean_Product_0;

			// Token: 0x040069E0 RID: 27104
			private static readonly IntPtr NativeMethodInfoPtr__OnGetAvailability_b__2_1_Internal_Boolean_Product_0;

			// Token: 0x040069E1 RID: 27105
			private static readonly IntPtr NativeMethodInfoPtr__OnGetAvailability_b__2_2_Internal_Boolean_Product_0;

			// Token: 0x040069E2 RID: 27106
			private static readonly IntPtr NativeMethodInfoPtr__OnGetAvailability_b__2_3_Internal_Boolean_Product_0;
		}
	}
}
